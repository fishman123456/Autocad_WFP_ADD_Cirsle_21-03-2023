using Autodesk.AutoCAD.ApplicationServices;
using Autodesk.AutoCAD.DatabaseServices;
using Autodesk.AutoCAD.Runtime;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace Autocad_WFP_ADD_Cirsle_21_03_2023
{
    public class Class1
    {
        public string sLayerName2;

        

       [CommandMethod("WF_Form")]
        public void Demo()
        {
            WPF_Form wp = new WPF_Form();
          wp.Show();
            
        }
      

        // метод создания слоя
        [CommandMethod("SetLayerCurrent")]

        public static void SetLayerCurrent()

        {

            // Get the current document and database

            Document acDoc = Application.DocumentManager.MdiActiveDocument;

            Database acCurDb = acDoc.Database;



            // Start a transaction

            using (Transaction acTrans = acCurDb.TransactionManager.StartTransaction())

            {

                // Open the Layer table for read

                LayerTable acLyrTbl;

                acLyrTbl = acTrans.GetObject(acCurDb.LayerTableId,

                                             OpenMode.ForRead) as LayerTable;



                string sLayerName = "centr";



                if (acLyrTbl.Has(sLayerName) == true)

                {

                    // Set the layer Center current

                    acCurDb.Clayer = acLyrTbl[sLayerName];



                    // Save the changes

                    acTrans.Commit();

                }



                // Dispose of the transaction

            }

        }
    }
}
