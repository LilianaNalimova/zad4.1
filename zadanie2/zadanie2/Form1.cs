using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace zadanie2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }
        Students db = new Students(@"Data Source= DESKTOP-KQTR1T6; Initial Catalog= Students; Integrated Security=SSPI;");

        private void button1_Click(object sender, EventArgs e)
        {
            int param = Convert.ToInt32(textBox1.Text);

            // Объявление переменной для хранения результата, возвращаемого процедурой
            var custquery = db.IvanovGetStudentById(param);

            // Исполнение хранимой процедуры и отображение результата в виде таблицы. 
            List<IvanovGetStudentByIdResult> test = new List<IvanovGetStudentByIdResult>(); // объявление переменной списка типа «результат работы процедуры» и его инициализация
            foreach (IvanovGetStudentByIdResult IvanovSProcedure in custquery)
            {
                test.Add(IvanovSProcedure);//Добавление нового элемента в списко

            }

            dataGridView1.DataSource = test; // Присваивание источнику данных DataGrid созданного выше списка. 

        }

        private void button2_Click(object sender, EventArgs e)
        {

            string param = Convert.ToString(textBox2.Text);

            // Объявление переменной для хранения результата, возвращаемого процедурой
            var custquery = db.GetStudentByName(param);

            // Исполнение хранимой процедуры и отображение результата в виде таблицы. 
            List<GetStudentByNameResult> test = new List<GetStudentByNameResult>(); // объявление переменной списка типа «результат работы процедуры» и его инициализация
            foreach (GetStudentByNameResult StudentProcedure in custquery)
            {
                test.Add(StudentProcedure);//Добавление нового элемента в списко

            }

            dataGridView1.DataSource = test; // Присваивание источнику данных DataGrid созданного выше списка. 
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();

        }
    }
}
