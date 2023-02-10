using DocumentFormat.OpenXml.Spreadsheet;
using SpreadsheetLight;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.RightsManagement;
using System.Text;
using System.Threading.Tasks;

namespace OutputExcelDocument
{
    internal class ExcelTemplate
    {
        public struct ST_INFO
        {
            public string Name;
        }

        public ExcelTemplate()
        {
        }
        
        public void CreateExcel(ST_INFO info)
        {
            m_stInfo.Name = info.Name;

            SLDocument sl = new SLDocument();

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
            //sl.SetCellValue("L11", "〇〇株式会社");
            sl.SetCellValue("L11", m_stInfo.Name);
            sl.SetCellValue("L12", "〒");
            sl.SetCellValue("L13", "東京都渋谷区〇〇〇〇");
            sl.SetCellValue("L14", "△△△△ビル10階");
            sl.SetCellValue("L15", "TEL(電話番号)：");


            sl.SaveAs("./test.xlsx");
        }

        private ST_INFO m_stInfo;
    }
}
