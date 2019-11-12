using System;
using System.Data;
using System.IO;
using Xceed.Words.NET;
using System.Windows.Forms;

namespace i_1_16_dotsu_kp
{
     class EmployeeListWord
    {
        private string fileName;
        private string oldFileName;
        
        public void CreateEmployeeList(DataTable dataTable, bool pdf)
        {
            try
            {
                fileName = @"D:\Учёба\РВиАПООН\Отчёты\Список сотрдуников " + DateTime.Now.ToString("HH.mm.ss_dd.MM.yyyy") + ".docx";
                using (DocX document = DocX.Create(fileName))
                {
                    document.MarginTop = 56.6f;
                    document.MarginLeft = 56.6f;
                    document.MarginRight = 28.3f;
                    document.MarginBottom = 56.6f;

                    var title = document.InsertParagraph();
                    var text = document.InsertParagraph();
                    var textList = document.InsertParagraph();
                    var titleTable = document.InsertParagraph();
                    var table = document.AddTable(dataTable.Rows.Count + 1, 5);
                    table.Design = Xceed.Document.NET.TableDesign.TableGrid;
                    var mainTable = document.InsertTable(table);

                    title.Append("Список сотрудников").Font("Times New Roman").FontSize(16).SetLineSpacing(Xceed.Document.NET.LineSpacingType.Line, 1.5f);
                    title.Alignment = Xceed.Document.NET.Alignment.both;
                    titleTable.Append("Список сотрудников").Font("Times New Roman").FontSize(16).SetLineSpacing(Xceed.Document.NET.LineSpacingType.Line, 1.5f);
                    titleTable.Alignment = Xceed.Document.NET.Alignment.center;

                    mainTable.Rows[0].Cells[0].Paragraphs[0].Append("№ п/п");
                    mainTable.Rows[0].Cells[1].Paragraphs[0].Append("Фамилия сотрудника");
                    mainTable.Rows[0].Cells[2].Paragraphs[0].Append("Имя сотрудника");
                    mainTable.Rows[0].Cells[3].Paragraphs[0].Append("Отчество сотрудника");
                    mainTable.Rows[0].Cells[4].Paragraphs[0].Append("Дата рождения");
                    mainTable.Rows[0].Cells[5].Paragraphs[0].Append("Номер аттестата");
                    mainTable.Rows[0].Cells[6].Paragraphs[0].Append("Название учебного заведения");
                    mainTable.Rows[0].Cells[7].Paragraphs[0].Append("Дата окончания учебного заведения");

                    for (int i = 0; i < dataTable.Rows.Count; i++)
                    {
                        mainTable.Rows[i + 1].Cells[0].Paragraphs[0].Append((i + 1).ToString());
                        for (int j = 0; j < dataTable.Columns.Count; j++)
                        {
                            mainTable.Rows[i + 1].Cells[j + 1].Paragraphs[0].Append(dataTable.Rows[i][j].ToString());

                        }
                    }

                    for (int i = 0; i < mainTable.RowCount; i++)
                        for (int j = 0; j < mainTable.ColumnCount; j++)
                        {
                            var cell = mainTable.Rows[i].Cells[j];
                            cell.Paragraphs[0].Font("Times New Roman").FontSize(12).SetLineSpacing(Xceed.Document.NET.LineSpacingType.Line, 1.15f);
                            cell.VerticalAlignment = Xceed.Document.NET.VerticalAlignment.Center;
                            cell.Paragraphs[0].Alignment = Xceed.Document.NET.Alignment.center;

                        }
                    document.Save();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                throw;
            }
        }
    }
}
