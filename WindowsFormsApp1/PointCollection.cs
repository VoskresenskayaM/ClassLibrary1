using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Soap;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace WindowsFormsApp1
{
    class PointCollection : CollectionBase
    {
        public Point3D Add(ClassLibrary1.Point point)
        {
            Point3D Item = new Point3D();
            List.Add(Item);
            return Item;
        }

        public Point3D Add(Point3D Item)
        {
            List.Add(Item);
            return Item;
        }

        public void Insert(int Index, Point3D Item)
        {
            List.Insert(Index, Item);
        }
        public void Remove(Point3D Item)
        {
            List.Remove(Item);
        }
        public Point3D this[int Index]
        {
            get
            {
                return (Point3D)List[Index];
            }
        }

        public void Save()
        {
            SaveFileDialog svDialog = new SaveFileDialog();
            svDialog.Filter = "Point file (*pf)|*pf";
            svDialog.DefaultExt = "pf";
            if (svDialog.ShowDialog() == DialogResult.OK)
            {

                FileStream fStriam = null;
                SoapFormatter mySoapFormater = new SoapFormatter();
                try
                {
                    fStriam = new FileStream(svDialog.FileName,
                        FileMode.Create, FileAccess.Write);
                    mySoapFormater.Serialize(fStriam, this);
                }
                catch(Exception e)
                {
                    MessageBox.Show(e.Message);
                }
                finally
                {
                    if (fStriam!=null) fStriam.Close();
                }

            }
        }





    }
}
