using System;
using System.Collections.Generic;
using System.Web.Mvc;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace JinxiaocunApp.Models
{
    public partial class Tender_GongGao
    {
        [Key][DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int TaskID { get; set; }

        [Display(Name="��Ŀ���")]
        public string SN { get; set; }
        public string SSN { get; set; }

        [Display(Name = "������λ")]
        public string PartmentT { get; set; }

        [Display(Name = "������")]
        public string ProposerT { get; set; }

        [DisplayFormat(DataFormatString="{0:yyyy-MM-dd}")]
        [Display(Name = "��������")]
        public Nullable<System.DateTime> CreateDate { get; set; }

        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}")]
        [Display(Name = "��ʼ����")]
        public Nullable<System.DateTime> BeginDate { get; set; }

        [Display(Name = "��������")]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}")]
        public Nullable<System.DateTime> EndDate { get; set; }

        [Display(Name = "����������ֹ����")]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}")]
        public Nullable<System.DateTime> AssessEndDate { get; set; }

        [Display(Name = "��Ŀ����")]
        public string Name { get; set; }

        [Display(Name = "�ɹ�����")]
        public string Types { get; set; }

        [Display(Name = "��Ŀ���")]
        public string Descs { get; set; }

        [Display(Name = "Ҫ�󸶿ʽ")]
        public string PayType { get; set; }

        [Display(Name = "����")]
        public Nullable<decimal> Counts { get; set; }

        [Display(Name = "��λ")]
        public string Unit { get; set; }

        [Display(Name = "��Ŀ��������")]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}")]
        public Nullable<System.DateTime> ProjectEndDate { get; set; }

        [Display(Name = "��ע")]
        public string Remark { get; set; }

        [Display(Name = "������֤")]
        public bool IsShenhe { get; set; }

        [Display(Name="�б�ģʽ")]
        public string TenderModel { get; set; }

        [Display(Name="Ͷ�꿪ʼʱ��")]
        public string BeginTime { get; set; }

        [Display(Name = "Ͷ�����ʱ��")]
        public string EndTime { get; set; }

        [Display(Name="��֤����")]
        public Nullable<decimal> CautionMoney { get; set; }

        public Nullable<decimal> PriceLost { get; set; }

        public Nullable<decimal> PriceTalk { get; set; }

        public bool? IsKaib { get; set; }

        public bool? IsPingb { get; set; }

        [Display(Name = "Ͷ��״̬")]
        public bool IsZhongb { get; set; }

        [Display(Name="ɾ�����")]
        public bool? IsDelete { get; set; }
        public List<Bemp_GongGao> Bemp_GongGaos { get; set; }

        public List<Tender_GongGao_Item> Tender_GongGao_Items { get; set; }

        public List<Tender_Purchase_GongGao> Tender_Purchase_GongGaos { get; set; }
    }
}
