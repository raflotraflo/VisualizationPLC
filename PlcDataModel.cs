using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VisualizationPLC
{
    public class PlcDataModel
    {
        ////{"SterW":"0",
        //"StatZaw_Y1":"1",
        //"StatZaw_Y2":"2",
        //"StatZaw_Y3":"0",
        //"StatZaw_Y4":"4",
        //"St_otw_Y1":"100",
        //"St_otw_Y2":"64",
        //"St_otw_Y3":"0",
        //"StatFiltr":"1",

        //"CisnPodZlozem":"1",
        //"PoziomFiltr":"1,14",
        //"Przeplyw_wod_pluczna":"2,5",
        //"Przep_woda_czysta":"0,1",
        //"rez3":"1,5",

        //"dataModyfikacji":"2016-02-19T22:47:47.000Z"}

        public int SterW { get; set; } 
        public int StatZaw_Y1 { get; set; } // stany 0, 1, 2
        public int StatZaw_Y2 { get; set; }
        public int StatZaw_Y3 { get; set; }
        public int StatZaw_Y4 { get; set; }
        public int St_otw_Y1 { get; set; } //
        public int St_otw_Y2 { get; set; } //
        public int St_otw_Y3 { get; set; } //

        public int StatFiltr { get; set; } //

        public decimal CisnPodZlozem { get; set; } //
        public decimal PoziomFiltr { get; set; } //
        public decimal Przeplyw_wod_pluczna { get; set; } //
        public decimal Przep_woda_czysta { get; set; } //
        public decimal rez3 { get; set; } //pusty

        public DateTime dataModyfikacji { get; set; }




    }
}
