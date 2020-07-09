using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarReportSystem {
    public partial class Form1 : Form {

        //バインディングリスト
        BindingList<CarReport> _CarReports = new BindingList<CarReport>();

        public Form1() {
            InitializeComponent();
            dgvCarReportData.DataSource = _CarReports;
        }


        //データの追加
        private void btDataAdd_Click(object sender, EventArgs e) {

            //記録者or車名が空白
            if(cbRecoder.Text == "" || cbCarName.Text == "") {
                displayErrorMessage("記録者と車名を両方入力してください。");
                return;
            }

            var carReport = new CarReport() {
                CreatedDate = dtpDate.Value.Date,
                Recoder = cbRecoder.Text,
                Maker = getRadioButton(),
                Name = cbCarName.Text,
                Report = tbReport.Text,
                Picture = pbCarImage.Image
            };

            //リストに追加
            _CarReports.Insert(0, carReport);
            //コンボボックスにアイテムを追加
            cbItemsAdd(cbRecoder.Text, cbCarName.Text);
            //入力後テキストクリア
            textBoxesClear();
            //ボタンを有効化
            activationButton();
            //選択解除
            dgvCarReportData.ClearSelection();

        }


        //テキストのクリア
        private void textBoxesClear() {
            dtpDate.Value = DateTime.Today;
            cbRecoder.Text = "";
            rbToyota.Checked = true;
            cbCarName.Text = "";
            tbReport.Text = "";
            pbCarImage.Image = null;
        }


        //コンボボックスにアイテムを追加
        private void cbItemsAdd(string recoderItem, string nameItem) {
            //記録者のアイテム登録
            if(!cbRecoder.Items.Contains(recoderItem)) {
                cbRecoder.Items.Add(recoderItem);
            }
            //車名のアイテム登録
            if(!cbCarName.Items.Contains(nameItem)) {
                cbCarName.Items.Add(nameItem);
            }
        }

        //ラジオボタンの判別
        private CarReport.CarMaker getRadioButton() {

            if(rbToyota.Checked) {
                return CarReport.CarMaker.トヨタ;
            } else if(rbNissan.Checked) {
                return CarReport.CarMaker.日産;
            } else if(rbHonda.Checked) {
                return CarReport.CarMaker.ホンダ;
            } else if(rbSubaru.Checked) {
                return CarReport.CarMaker.スバル;
            } else if(rbGaisya.Checked) {
                return CarReport.CarMaker.外車;
            } else if(rbSonota.Checked) {
                return CarReport.CarMaker.その他;
            } else {
                return CarReport.CarMaker.DEFAULT;
            }
        }


        //画像を開く
        private void btImageOpen_Click(object sender, EventArgs e) {
            {
                if(ofdOpenData.ShowDialog() == DialogResult.OK) {
                    //選択した画像をピクチャーボックスに表示
                    pbCarImage.Image = Image.FromFile(ofdOpenData.FileName);
                    //ピクチャーボックスのサイズに画像を調整
                    pbCarImage.SizeMode = PictureBoxSizeMode.StretchImage;
                }
            }
        }


        //画像を削除
        private void btImageClear_Click(object sender, EventArgs e) {
            pbCarImage.Image = null;
        }


        //終了
        private void btEnd_Click(object sender, EventArgs e) {
            Application.Exit();
        }


        //データの削除
        private void btDataClear_Click(object sender, EventArgs e) {
            textBoxesClear();   //テキストボックスのクリア
            _CarReports.RemoveAt(dgvCarReportData.CurrentRow.Index);    //要素の削除
            dgvCarReportData.ClearSelection();  //選択解除
            //ボタンの無効化を判断
            invalidationButton();

        }


        //データグリッドビューを選択
        private void dgvCarReportData_Click(object sender, EventArgs e) {
            //データがなかった場合
            if(dgvCarReportData.CurrentRow == null) {
                return;
            }

            CarReport selectedCarReport = _CarReports[dgvCarReportData.CurrentRow.Index];

            getData(selectedCarReport);

        }


        //エラーメッセージボックスの表示
        private void displayErrorMessage(string textMessage) {
            MessageBox.Show(textMessage,
                "エラー",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error);
        }


        //データの修正
        private void btDataFix_Click(object sender, EventArgs e) {
            if(dgvCarReportData.CurrentRow == null) {
                return;
            }

            CarReport selectedCarReport = _CarReports[dgvCarReportData.CurrentRow.Index];

            //データをセット
            setData(selectedCarReport);
            //リフレッシュ
            dgvCarReportData.Refresh();
        }


        //ゲットデータ
        private void getData(CarReport selectedCR) {

            dtpDate.Value = selectedCR.CreatedDate;
            cbRecoder.Text = selectedCR.Recoder;
            cbCarName.Text = selectedCR.Name;
            tbReport.Text = selectedCR.Report;
            pbCarImage.Image = selectedCR.Picture;

            //ラジオボタン
            switch(selectedCR.Maker) {
                case CarReport.CarMaker.DEFAULT:
                    break;
                case CarReport.CarMaker.トヨタ:
                    rbToyota.Checked = true;
                    break;
                case CarReport.CarMaker.日産:
                    rbNissan.Checked = true;
                    break;
                case CarReport.CarMaker.ホンダ:
                    rbHonda.Checked = true;
                    break;
                case CarReport.CarMaker.スバル:
                    rbSubaru.Checked = true;
                    break;
                case CarReport.CarMaker.外車:
                    rbGaisya.Checked = true;
                    break;
                case CarReport.CarMaker.その他:
                    rbSonota.Checked = true;
                    break;
                default:
                    break;
            }
        }


        //セットデータ
        private void setData(CarReport selectedCR) {

            selectedCR.CreatedDate = dtpDate.Value;
            selectedCR.Recoder = cbRecoder.Text;
            selectedCR.Maker = getRadioButton();
            selectedCR.Name = cbCarName.Text;
            selectedCR.Report = tbReport.Text;
            selectedCR.Picture = pbCarImage.Image;
        }


        //セーブファイルダイアログを表示
        private void btDataSave_Click(object sender, EventArgs e) {
            if(sfdSaveData.ShowDialog() == DialogResult.OK) {
                BinaryFormatter formatter = new BinaryFormatter();

                //ファイルストリームを生成
                using(FileStream fs = new FileStream(sfdSaveData.FileName, FileMode.Create)) {
                    try {
                        //シリアル化して保存
                        formatter.Serialize(fs, _CarReports);
                    } catch(SerializationException se) {
                        Console.WriteLine("Failed to serialize. Reason: " + se.Message);
                        throw;
                    }
                }
            }
        }

        //オープンファイルダイアログを表示
        private void btDataOpen_Click(object sender, EventArgs e) {
            if(ofdOpenData.ShowDialog() == DialogResult.OK) {
                using(FileStream fs = new FileStream(ofdOpenData.FileName, FileMode.Open)) {
                    try {
                        BinaryFormatter formatter = new BinaryFormatter();
                        //逆シリアル化して読み込む
                        _CarReports = (BindingList<CarReport>)formatter.Deserialize(fs);
                        //データグリッドビューに再設定
                        dgvCarReportData.DataSource = _CarReports;
                        //選択されている箇所を各コントロールへ表示
                        dgvCarReportData_Click(sender, e);
                    } catch(SerializationException se) {
                        Console.WriteLine("Failed to deserialize. Reason: " + se.Message);
                        throw;
                    }
                }
            }
        }

        //ボタンを有効化
        private void activationButton() {
            btDataClear.Enabled = true;
            btDataFix.Enabled = true;
        }

        //ボタンを無効化
        private void invalidationButton() {
            //if(dgvCarReportData.CurrentRow.Index)
            btDataClear.Enabled = false;
            btDataFix.Enabled = false;
        }
    }
}
