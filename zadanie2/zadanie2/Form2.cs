using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace zadanie2
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
        Students db = new Students(@"Data Source= DESKTOP-KQTR1T6; Initial Catalog= Students; Integrated Security=SSPI;");

        private void button1_Click(object sender, EventArgs e)
        {
            

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            string param = Convert.ToString(textBox1.Text);

            // Объявление переменной для хранения результата, возвращаемого процедурой
            var custquery = db.GetSubjectByTitle(param);

            // Исполнение хранимой процедуры и отображение результата в виде таблицы. 
            List<GetSubjectByTitleResult> test = new List<GetSubjectByTitleResult>(); // объявление переменной списка типа «результат работы процедуры» и его инициализация
            foreach (GetSubjectByTitleResult TitleProcedure in custquery)
            {
                test.Add(TitleProcedure);//Добавление нового элемента в списко

            }

            dataGridView1.DataSource = test; // Присваивание источнику данных DataGrid созданного выше списка. 
        }
    }
}
