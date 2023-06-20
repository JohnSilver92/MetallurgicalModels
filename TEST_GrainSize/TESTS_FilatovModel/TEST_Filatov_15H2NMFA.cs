﻿using GrainSize_lib;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Data;

namespace TEST_GrainSize.TESTS_FilatovModel
{
    [TestClass]
    public class TEST_Filatov_15H2NMFA
    {
        [TestMethod]
        public void TestCalcGrainSize()
        {
            float q = -1;
            int objNumber = 1;
            float currentTime = 3600;
            DataTable materialTable = new DataTable();
            DataTable resultsTable = new DataTable();
            DataTable chemTable = new DataTable();

            materialTable.Columns.Add(new DataColumn("Индекс", typeof(int)));
            materialTable.Columns.Add(new DataColumn("Временная экспонента", typeof(float)));
            materialTable.Columns.Add(new DataColumn("Предэкспоненциальный множитель А", typeof(float)));

            resultsTable.Columns.Add(new DataColumn("Индекс", typeof(int)));
            resultsTable.Columns.Add(new DataColumn("Температура", typeof(float)));
            DataRow resultTableRow = resultsTable.NewRow();
            resultTableRow["Индекс"] = objNumber;
            resultTableRow["Температура"] = 850.0484381;
            resultsTable.Rows.Add(resultTableRow);



            DataRow materialTableRow = materialTable.NewRow();
            materialTableRow["Индекс"] = objNumber;
            materialTableRow["Временная экспонента"] = 0.211;
            materialTableRow["Предэкспоненциальный множитель А"] = 76671;

            materialTable.Rows.Add(materialTableRow);
            chemTable.Columns.Add(new DataColumn("Элемент", typeof(string)));
            chemTable.Columns.Add(new DataColumn("%", typeof(float)));
            DataRow chemRow1 = chemTable.NewRow();
            chemRow1["Элемент"] = "C";
            chemRow1["%"] = "0,15";
            chemTable.Rows.Add(chemRow1);

            DataRow chemRow2 = chemTable.NewRow();
            chemRow2["Элемент"] = "Si";
            chemRow2["%"] = "0,3";
            chemTable.Rows.Add(chemRow2);

            DataRow chemRow3 = chemTable.NewRow();
            chemRow3["Элемент"] = "Mn";
            chemRow3["%"] = "0,5";
            chemTable.Rows.Add(chemRow3);

            DataRow chemRow4 = chemTable.NewRow();
            chemRow4["Элемент"] = "Cr";
            chemRow4["%"] = "2";
            chemTable.Rows.Add(chemRow4);

            DataRow chemRow5 = chemTable.NewRow();
            chemRow5["Элемент"] = "Cu";
            chemRow5["%"] = "0,3";
            chemTable.Rows.Add(chemRow5);

            DataRow chemRow6 = chemTable.NewRow();
            chemRow6["Элемент"] = "Mo";
            chemRow6["%"] = "0,6";
            chemTable.Rows.Add(chemRow6);

            DataRow chemRow8 = chemTable.NewRow();
            chemRow8["Элемент"] = "Ni";
            chemRow8["%"] = "1,2";
            chemTable.Rows.Add(chemRow8);

            DataRow chemRow9 = chemTable.NewRow();
            chemRow9["Элемент"] = "V";
            chemRow9["%"] = "0,1";
            chemTable.Rows.Add(chemRow9);

            DataRow chemRow10 = chemTable.NewRow();
            chemRow10["Элемент"] = "W";
            chemRow10["%"] = "0,00";
            chemTable.Rows.Add(chemRow10);

            DataRow chemRow11 = chemTable.NewRow();
            chemRow11["Элемент"] = "Al";
            chemRow11["%"] = "0,00";
            chemTable.Rows.Add(chemRow11);

            DataRow chemRow12 = chemTable.NewRow();
            chemRow12["Элемент"] = "P";
            chemRow12["%"] = "0,02";
            chemTable.Rows.Add(chemRow12);

            DataRow chemRow13 = chemTable.NewRow();
            chemRow13["Элемент"] = "As";
            chemRow13["%"] = "0,04";
            chemTable.Rows.Add(chemRow13);

            DataRow chemRow14 = chemTable.NewRow();
            chemRow14["Элемент"] = "Ti";
            chemRow14["%"] = "0,00";
            chemTable.Rows.Add(chemRow14);

            var result = new GrainSize_Calc_Filatov();
            var results = result.CalcGrainSize(objNumber, q, currentTime, chemTable, materialTable, resultsTable);


            Assert.AreEqual(Math.Round(results, 3), 0,514);
        }
    }
}
