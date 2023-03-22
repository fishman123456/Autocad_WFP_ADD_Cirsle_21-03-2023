using Autodesk.AutoCAD.ApplicationServices;
using Autodesk.AutoCAD.DatabaseServices;
using Autodesk.AutoCAD.Runtime;
using Autodesk.AutoCAD.Geometry;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Policy;

namespace Autocad_WFP_ADD_Cirsle_21_03_2023
{
   public class AddCircle_Class
    {
        //[CommandMethod("AddCircle")]

        //public static void AddCircle()

        //{
          
        //    // Get the current document and database

        //    Document acDoc = Application.DocumentManager.MdiActiveDocument;

        //    Database acCurDb = acDoc.Database;



        //    // Start a transaction

        //    using (Transaction acTrans = acCurDb.TransactionManager.StartTransaction())

        //    {

        //        // Open the Block table for read

        //        BlockTable acBlkTbl;

        //        acBlkTbl = acTrans.GetObject(acCurDb.BlockTableId,

        //                                     OpenMode.ForRead) as BlockTable;



        //        // Open the Block table record Model space for write

        //        BlockTableRecord acBlkTblRec;

        //        acBlkTblRec = acTrans.GetObject(acBlkTbl[BlockTableRecord.ModelSpace],

        //                                        OpenMode.ForWrite) as BlockTableRecord;



        //        // Create a circle that is at 2,3 with a radius of 4.25

        //        Circle acCirc = new Circle();

        //        acCirc.SetDatabaseDefaults();

        //        acCirc.Center = new Point3d(2, 3, 0);

        //        acCirc.Radius = 4.25;



        //        // Add the new object to the block table record and the transaction

        //        acBlkTblRec.AppendEntity(acCirc);

        //        acTrans.AddNewlyCreatedDBObject(acCirc, true);



        //        // Save the new object to the database

        //        acTrans.Commit();

        //    }

        //}
    }
 
}
