using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using SSProject.Controller;
using SSProject.Model;

namespace SSProject
{
    public partial class Form1 : Form
    {
        private StudentController controller = new StudentController();

        public Form1()
        {
            InitializeComponent();
        }

        // Form yüklendiğinde öğrencileri ComboBox'lara yerleştir
        private void Form1_Load(object sender, EventArgs e)
        {
            ApplyPortfolioTheme();
            RefreshStudentComboBoxes();
        }

        private void ApplyPortfolioTheme()
        {
            BackColor = Color.FromArgb(240, 244, 250);
            Font = new Font("Segoe UI", 9F, FontStyle.Regular);
            Text = "Student Course Management System";
            StartPosition = FormStartPosition.CenterScreen;

            tpOgrenci.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            tpOgrenci.Padding = new Point(18, 8);

            foreach (TabPage page in tpOgrenci.TabPages)
            {
                page.BackColor = Color.White;
                page.Padding = new Padding(18);
            }

            StyleControls(this);

            dgvDersler.BackgroundColor = Color.White;
            dgvDersler.BorderStyle = BorderStyle.None;
            dgvDersler.EnableHeadersVisualStyles = false;
            dgvDersler.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(37, 99, 235);
            dgvDersler.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgvDersler.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            dgvDersler.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(248, 250, 252);
            dgvDersler.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void StyleControls(Control parent)
        {
            foreach (Control control in parent.Controls)
            {
                Button button = control as Button;
                if (button != null)
                {
                    button.BackColor = Color.FromArgb(37, 99, 235);
                    button.ForeColor = Color.White;
                    button.FlatStyle = FlatStyle.Flat;
                    button.FlatAppearance.BorderSize = 0;
                    button.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
                    button.Cursor = Cursors.Hand;
                }

                Label label = control as Label;
                if (label != null)
                {
                    label.ForeColor = Color.FromArgb(51, 65, 85);
                    label.Font = new Font("Segoe UI", 9F, FontStyle.Regular);
                }

                TextBox textBox = control as TextBox;
                if (textBox != null)
                {
                    textBox.BorderStyle = BorderStyle.FixedSingle;
                    textBox.Font = new Font("Segoe UI", 9F, FontStyle.Regular);
                }

                ComboBox comboBox = control as ComboBox;
                if (comboBox != null)
                {
                    comboBox.FlatStyle = FlatStyle.Flat;
                    comboBox.Font = new Font("Segoe UI", 9F, FontStyle.Regular);
                }

                StyleControls(control);
            }
        }

        // Öğrenci ekleme butonuna tıklandığında çalışır
        private void btnOgrenciEkle_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtAd.Text.Trim()) || string.IsNullOrEmpty(txtSoyad.Text.Trim()) ||
                string.IsNullOrEmpty(txtNumara.Text.Trim()) || string.IsNullOrEmpty(txtBolum.Text.Trim()))
            {
                MessageBox.Show("Lütfen tüm öğrenci bilgilerini giriniz.");
                return;
            }

            Student student = new Student
            {
                FirstName = txtAd.Text.Trim(),
                LastName = txtSoyad.Text.Trim(),
                StudentNumber = txtNumara.Text.Trim(),
                Department = txtBolum.Text.Trim()
            };

            if (!controller.TryAddStudent(student))
            {
                MessageBox.Show("Bu öğrenci numarası zaten kayıtlı.");
                return;
            }

            // Arayüz temizleniyor ve ComboBox güncelleniyor
            ClearStudentFields();
            RefreshStudentComboBoxes();
            MessageBox.Show("Öğrenci eklendi.");
        }

        // Ders ekle butonuna tıklanınca çalışır
        private void btnDersEkle_Click(object sender, EventArgs e)
        {
            // Seçilen öğrenci alınır
            Student selectedStudent = cmbOgrenciler.SelectedItem as Student;

            if (selectedStudent == null)
            {
                MessageBox.Show("Lütfen öğrenci seçiniz.");
                return;
            }

            int credit;
            if (string.IsNullOrEmpty(txtDersAd.Text.Trim()) || string.IsNullOrEmpty(txtDersKod.Text.Trim()) ||
                !int.TryParse(txtKredi.Text, out credit) || credit <= 0)
            {
                MessageBox.Show("Ders adı, ders kodu ve geçerli bir kredi değeri giriniz.");
                return;
            }

            if (controller.CourseCodeExists(selectedStudent, txtDersKod.Text.Trim()))
            {
                MessageBox.Show("Bu ders kodu seçili öğrenci için zaten kayıtlı.");
                return;
            }

            Course course = new Course
            {
                CourseName = txtDersAd.Text.Trim(),
                CourseCode = txtDersKod.Text.Trim(),
                Credit = credit,
                Midterm = (int)nudVize.Value,
                Final = (int)nudFinal.Value
            };

            // Controller ile ders öğrenciye eklenir
            controller.AddCourseToStudent(selectedStudent, course);

            MessageBox.Show("Ders başarıyla eklendi.");
            ClearCourseFields();
        }

        // Dersleri listele butonuna tıklanınca çalışır
        private void btnListele_Click(object sender, EventArgs e)
        {
            // Seçilen öğrenci alınır
            Student selectedStudent = cmbOgrenciListe.SelectedItem as Student;

            if (selectedStudent == null)
            {
                MessageBox.Show("Lütfen öğrenci seçiniz.");
                return;
            }

            // DataGridView temizlenir ve dersler yüklenir
            dgvDersler.DataSource = null;
            dgvDersler.DataSource = controller.GetCoursesOfStudent(selectedStudent);
        }

        // Öğrenci alanlarını temizle
        private void ClearStudentFields()
        {
            txtAd.Clear();
            txtSoyad.Clear();
            txtNumara.Clear();
            txtBolum.Clear();
        }

        // Ders alanlarını temizle
        private void ClearCourseFields()
        {
            txtDersAd.Clear();
            txtDersKod.Clear();
            txtKredi.Clear();
            nudVize.Value = 0;
            nudFinal.Value = 0;
        }

        // Tüm öğrenci ComboBox'larını güncelle
        private void RefreshStudentComboBoxes()
        {
            var allStudents = controller.GetAllStudents();

            cmbOgrenciler.DataSource = null;
            cmbOgrenciler.DataSource = allStudents;

            cmbOgrenciListe.DataSource = null;
            cmbOgrenciListe.DataSource = allStudents;
        }
    }
}
