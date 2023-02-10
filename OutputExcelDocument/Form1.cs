using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using SpreadsheetLight;
using DocumentFormat.OpenXml;
using DocumentFormat.OpenXml.Spreadsheet;
using System.Security.Cryptography;

namespace OutputExcelDocument
{
    public partial class Form1 : Form
    {
        public const int DOCTYPE1 = 0;
        public const int DOCTYPE2 = 1;
        public const int DOCTYPE3 = 2;
        public const int DOCTYPE4 = 3;
        public const int DOCTYPE5 = 4;

        public Form1()
        {
            InitializeComponent();

            
            //画面初期化
            List<string> docType = new List<string>();
            docType.Add("領収書");
            docType.Add("請求書");
            docType.Add("納品書");
            docType.Add("見積書");
            docType.Add("始末書");

            foreach(string s in docType)
            {
                cmbDocumentType.Items.Add(s);
            }

            cmbDocumentType.SelectedIndex = DOCTYPE1;

#if false
            SLDocument sl = new SLDocument();

            //sl.SetCellValue("A1", "Hello World");


            sl.RenameWorksheet(SLDocument.DefaultFirstSheetName, "領収書テンプレ");

            // スタイル作成
            SLStyle style = null;

            // 外枠罫線の形式と色を設定
            style = sl.CreateStyle();
            style.SetTopBorder(BorderStyleValues.Thin, System.Drawing.Color.Black);
            sl.SetCellStyle("B2", "O2", style);

            style = sl.CreateStyle();
            style.SetBottomBorder(BorderStyleValues.Thin, System.Drawing.Color.Black);
            sl.SetCellStyle("B17", "O17", style);

            style = sl.CreateStyle();
            style.SetLeftBorder(BorderStyleValues.Thin, System.Drawing.Color.Black);
            sl.SetCellStyle("B2", "B17", style);

            style = sl.CreateStyle();
            style.SetRightBorder(BorderStyleValues.Thin, System.Drawing.Color.Black);
            sl.SetCellStyle("O2", "O17", style);

            // 「領収書」を入力
            style = sl.CreateStyle();
            style.SetFont("Meiryo UI", 20);
            style.SetFontBold(true);
            sl.SetCellStyle("H2", style);
            sl.SetRowHeight(2, 38);
            sl.SetCellValue("H2", "領　収　書");

            // 「No」を入力
            style = sl.CreateStyle();
            style.SetFont("Meiryo UI", 11);
            sl.SetCellStyle("L3", "L4", style);
            sl.SetCellValue("L3", "No.");
            sl.SetCellValue("L4", "発行日");

            // 「御中」を入力
            style = sl.CreateStyle();
            style.SetFont("Meiryo UI", 11);
            style.SetVerticalAlignment(VerticalAlignmentValues.Center);
            style.SetHorizontalAlignment(HorizontalAlignmentValues.Left);
            style.SetBottomBorder(BorderStyleValues.Thin, System.Drawing.Color.Black);
            sl.SetCellStyle("C5", "G5", style);
            sl.SetRowHeight(5, 30);
            sl.SetCellValue("G5", "御中");

            // 「文字」を入力
            style = sl.CreateStyle();
            style.SetFont("Meiryo UI", 11);
            sl.SetCellStyle("C7", style);
            sl.SetCellValue("C7", "下記、正に領収致しました。");

            // 「金額」を入力
            style = sl.CreateStyle();
            style.SetFont("Meiryo UI", 14);
            style.SetVerticalAlignment(VerticalAlignmentValues.Center);
            style.SetHorizontalAlignment(HorizontalAlignmentValues.Center);
            style.SetBottomBorder(BorderStyleValues.Thick, System.Drawing.Color.Black);
            style.Fill.SetPatternType(PatternValues.Solid);
            style.Fill.SetPatternForegroundColor(System.Drawing.Color.FromArgb(215, 228, 242));
            sl.SetCellStyle("C8", "N8", style);
            sl.SetRowHeight(8, 38);
            sl.SetCellValue("D8", "金額：");
            sl.SetCellValue("F8", "￥");

            // 「文字」を入力
            style = sl.CreateStyle();
            style.SetFont("Meiryo UI", 11);
            sl.SetCellStyle("D9", "D12", style);
            sl.SetCellValue("D9", "但");
            sl.SetCellValue("D11", "内訳");
            sl.SetCellValue("D12", "消費税");

            // 「文字」を入力
            style = sl.CreateStyle();
            style.SetFont("Meiryo UI", 11);
            sl.SetCellStyle("L11", "L15", style);
            sl.SetCellValue("L11", "〇〇株式会社");
            sl.SetCellValue("L12", "〒");
            sl.SetCellValue("L13", "東京都渋谷区〇〇〇〇");
            sl.SetCellValue("L14", "△△△△ビル10階");
            sl.SetCellValue("L15", "TEL(電話番号)：");


            sl.SaveAs("./test.xlsx");
#endif
        }

        private void btnCreateExcel_Click(object sender, EventArgs e)
        {
            // インスタンス生成
            ExcelTemplate template = new ExcelTemplate();
            ExcelTemplate.ST_INFO stInfo;
            stInfo.Name = textCompanyName.Text;

            template.CreateExcel(stInfo);
        }
    }
}
