import { workplanQRcode } from './../../../../_core/_model/workplanQRcode';
import { Component, OnInit, ViewChild } from '@angular/core';
import { ActivatedRoute } from '@angular/router';
import { DisplayTextModel, QRCodeGenerator } from '@syncfusion/ej2-angular-barcode-generator';
import { DatePipe } from '@angular/common';
import { TextBoxComponent } from '@syncfusion/ej2-angular-inputs';
import { InkService } from 'src/app/_core/_service/ink.service';
import { ScheduleService } from 'src/app/_core/_service/schedule.service';

@Component({
  selector: 'app-print-qrcode-glue-workplan',
  templateUrl: './print-qrcode-glue-workplan.component.html',
  styleUrls: ['./print-qrcode-glue-workplan.component.css'],
  providers: [DatePipe]
})
export class PrintQrcodeGlueWorkplanComponent implements OnInit {

  public qrcode = '';
  public ink = '';
  public qty: number = 0;
  public batch = 'DEFAULT';
  public mfgTemp = new Date();
  public kg: number = 0;
  public mfg = this.datePipe.transform(this.mfgTemp, 'yyyyMMdd');
  public exp = this.datePipe.transform(new Date(new Date().setMonth(new Date().getMonth() + 4)), 'yyyyMMdd');
  public data: workplanQRcode = {
    qty: 0,
    recipe: null,
    part: null,
    modelName: null,
    article: null
  };
  @ViewChild('barcode')
  public barcode: QRCodeGenerator;
  @ViewChild('displayText')
  public displayText: TextBoxComponent;
  public displayTextMethod: DisplayTextModel = {
    visibility: false
  };
  name: any;
  modelName: any;
  part: any;
  constructor(
    private route: ActivatedRoute,
    private datePipe: DatePipe,
    private activatedRoute: ActivatedRoute,
    private scheduleService: ScheduleService
  ) {
  }

  ngOnInit(): void {
    this.onRouteChange();
  }

  getByID(Id) {
    this.scheduleService.getPrintQRcodeByScheduleID(Id)
      .subscribe((res: any) => {
        this.data = res;
        this.mfg = this.datePipe.transform(this.mfgTemp, 'yyyyMMdd');
        this.exp = this.datePipe.transform(this.mfgTemp.setDate(this.mfgTemp.getDate() + 180), 'yyyyMMdd');
        this.qrcode = `${this.data.article}-${this.data.recipe}-${this.ink}-${this.mfg}-${this.exp}-${this.qty}`;
      }, error => {
      });
  }

  onChangeProductionDate(args) {
    if (args.isInteracted) {
      const pd = args.value as Date;
      this.mfg = this.datePipe.transform(pd, 'yyyyMMdd');
      this.exp = this.datePipe.transform(pd.setDate(pd.getDate() + 180), 'yyyyMMdd');
      this.qrcode = `${this.data.article}-${this.data.recipe}-${this.ink}-${this.mfg}-${this.exp}-${this.qty}`;
    }
  }

  printData() {
    const printContent = document.getElementById('qrcode');
    const WindowPrt = window.open('', '_blank', 'left=0,top=0,width=1000,height=900,toolbar=0,scrollbars=0,status=0');
    // WindowPrt.document.write(printContent.innerHTML);
    WindowPrt.document.write(`
    <html>
      <head>
      </head>
      <style>
        * {
          box-sizing: border-box;
          -moz-box-sizing: border-box;
        }

        .content {
          page-break-after: always;
          clear: both;
        }

        .content .qrcode {
          float:left;
          width: 100px;
          margin-top: 10px;
          padding: 0;
          margin-left: 0px;
        }

        .content .info {
          float:left;
          list-style: none;
          width: 200px;
        }
        .content .info ul {
          float:left;
          list-style: none;
          padding: 0px;
          font-size: 13px;
          margin: 0px;
          margin-top: 10px;
          font-weight: bold;
          word-wrap: break-word;
        }

        @page {
          size: 2.65 1.20 in;
          page-break-after: always;
          margin: 0;
        }
        @media print {
          html, body {
            width: 90mm; // Chi co nhan millimeter
          }
        }
      </style>
      <body onload="window.print(); window.close()">
      <div class='content'>
        <div class='qrcode'>
         ${printContent.innerHTML}
         </div>
          <div class='info'>
          <ul>
            <li class='subInfo'>Model Name: ${this.modelName}</li>
            <li class='subInfo'>Article#: ${this.data.article}</li>
            <li class='subInfo'>Recipe: ${this.data.recipe}</li>
            <li class='subInfo'>Part: ${this.part}</li>
            <li class='subInfo'>Ink Name: ${this.ink}</li>
            <li class='subInfo'>MFG: ${this.mfg}</li>
            <li class='subInfo'>EXP: ${this.exp}</li>
            <li class='subInfo'>KG: ${this.qty}</li>
          </ul>
         </div>
      </div>
      </body>
    </html>
    `);
    WindowPrt.document.close();
    // WindowPrt.focus();
    // WindowPrt.print();
    // WindowPrt.close();
  }

  onRouteChange() {
    this.route.queryParams.subscribe(params => {
      this.data.qty = params.qty
      this.data.article = params.article
      this.data.recipe = params.recipe
      this.modelName = params.modelName
      this.part = params.part
    })
    // this.route.data.subscribe(data => {
    //   this.getByID(this.route.snapshot.params.id);
    //   this.name = this.route.snapshot.params.name;
    // });
  }

  onChangeBatch(args) {
    this.ink = args
    this.qrcode = `${this.data.article}-${this.data.recipe}-${this.ink}-${this.mfg}-${this.exp}-${this.qty}`;
  }
  // onChangeInk(args) {
  //   this.qrcode = `${this.mfg}-${args}-${this.route.snapshot.paramMap.get('code')}`;
  // }

}
