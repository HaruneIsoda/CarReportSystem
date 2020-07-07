using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarReportSystem {
    class CarReport {

        //日付
        [System.ComponentModel.DisplayName("作成日")]
        public DateTime CreatedDate { get; set; }
        //記録者
        [System.ComponentModel.DisplayName("記録者")]
        public string Recoder { get; set; }
        //メーカー
        [System.ComponentModel.DisplayName("メーカー")]
        public CarMaker Maker { get; set; }
        //車名
        [System.ComponentModel.DisplayName("車名")]
        public string Name { get; set; }
        //レポート
        [System.ComponentModel.DisplayName("レポート")]
        public string Report { get; set; }
        //画像
        [System.ComponentModel.DisplayName("画像")]
        public Image Picture { get; set; }


        //メーカー(列挙型)
        public enum CarMaker {
            DEFAULT,
            トヨタ,
            日産,
            ホンダ,
            スバル,
            外車,
            その他
        }

    }
}
