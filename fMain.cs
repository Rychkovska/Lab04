using Lab04;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab04
{
	public partial class fMain : Form
	{
		public fMain()
		{
			InitializeComponent();
		}

		private void fMain_Load(object sender, EventArgs e)
		{
			gvBooks.AutoGenerateColumns = false;

			DataGridViewColumn column = new DataGridViewTextBoxColumn();
			column.DataPropertyName = "title";
			column.Name = "Назва";
			gvBooks.Columns.Add(column);

			column = new DataGridViewTextBoxColumn();
			column.DataPropertyName = "author";
			column.Name = "Автор";
			gvBooks.Columns.Add(column);

			column = new DataGridViewTextBoxColumn();
			column.DataPropertyName = "NumPages";
			column.Name = "Кільість сторінок";
			gvBooks.Columns.Add(column);

			column = new DataGridViewTextBoxColumn();
			column.DataPropertyName = "WordCount"; // Відображає загальну кількість слів
			column.Name = "Загальна кількість слів";
			gvBooks.Columns.Add(column);

			column = new DataGridViewTextBoxColumn();
			column.DataPropertyName = "publisher";
			column.Name = "Видавництво";
			gvBooks.Columns.Add(column);

			column = new DataGridViewTextBoxColumn();
			column.DataPropertyName = "yearpublished";
			column.Name = "Рік опублікування";
			gvBooks.Columns.Add(column);

			column = new DataGridViewTextBoxColumn();
			column.DataPropertyName = "language";
			column.Name = "Мова";
			column.Width = 60;
			gvBooks.Columns.Add(column);

			column = new DataGridViewTextBoxColumn();
			column.DataPropertyName = "genre";
			column.Name = "Жанр";
			column.Width = 60;
			gvBooks.Columns.Add(column);

			column = new DataGridViewTextBoxColumn();
			column.DataPropertyName = "WordsPerPage"; // Відображає кількість слів на сторінці
			column.Name = "Кількість слів на одній сторінці";
			gvBooks.Columns.Add(column);

			column = new DataGridViewCheckBoxColumn();
			column.DataPropertyName = "BigorSmall";
			column.Name = "Книжка велика";
			gvBooks.Columns.Add(column);


			bindSrcBooks.Add(new Book ("Фах","Айзек Азімов", 40, 12000, "Astounding Science Fiction", 1957,
				"англійська", "наукова фантастика", 300, false));
			EventArgs args = new EventArgs(); OnResize(args);
		}

		private void btnAdd_Click(object sender, EventArgs e)
		{
			Book book = new Book();

			fBook ft = new fBook(book);
			if (ft.ShowDialog() == DialogResult.OK)
			{
				bindSrcBooks.Add(book);
			}
		}

		private void btnEdit_Click(object sender, EventArgs e)
		{
			Book book = (Book)bindSrcBooks.List[bindSrcBooks.Position];

			fBook fb = new fBook(book);
			if (fb.ShowDialog() == DialogResult.OK)
			{
				bindSrcBooks.List[bindSrcBooks.Position] = book;
			}
		}


		private void btnDel_Click(object sender, EventArgs e)
		{
			if (MessageBox.Show("Видалити поточний запис?", "Видалення запису",
				MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
			{
				
			}
		}

		private void btnClear_Click(object sender, EventArgs e)
		{
			if (MessageBox.Show("Очистити таблицю?\n\nВсі дані будуть втрачені", "Очищення даних",
				MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
			{
				
			}
		}

		private void btnExit_Click(object sender, EventArgs e)
		{
			if (MessageBox.Show("Закрити застосунок?", "Вихід з програми", MessageBoxButtons.OKCancel,
				MessageBoxIcon.Question) == DialogResult.OK)
			{
				Application.Exit();
			}
		}

		private void fMain_Resize(object sender, EventArgs e)
		{
			int buttonsSize = 5 * btnAdd.Width + 2 * tsSeparator1.Width + 30;
			btnExit.Margin = new Padding(Width - buttonsSize, 0, 0, 0);
		}
	}
}
