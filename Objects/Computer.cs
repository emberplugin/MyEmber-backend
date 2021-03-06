﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace IIS.MyTestApplicationEmber
{
    using System;
    using System.Xml;
    using ICSSoft.STORMNET.Business;
    using ICSSoft.STORMNET;
    using ICSSoft.STORMNET.Business.Audit;
    using ICSSoft.STORMNET.Business.Audit.Objects;
    
    
    //  *** Start programmer edit section *** (Using statements)

    //  *** End programmer edit section *** (Using statements)


    /// <summary>
    /// Computer.
    /// </summary>
    //  *** Start programmer edit section *** (Computer CustomAttributes)

    //  *** End programmer edit section *** (Computer CustomAttributes)
    [BusinessServer("IIS.MyTestApplicationEmber.ComputerBS, MyTestApplicationEmber.BusinessServers", ICSSoft.STORMNET.Business.DataServiceObjectEvents.OnAllEvents)]
    [AutoAltered()]
    [AccessType(ICSSoft.STORMNET.AccessType.none)]
    [View("AuditView", new string[] {
            "SerialNumber as \'Serial number\'",
            "ManufactureDate as \'Manufacture date\'",
            "Type as \'Type\'",
            "Description as \'Description\'"})]
    [AssociatedDetailViewAttribute("AuditView", "ComputerPart", "AuditView", true, "", "Computer part", true, new string[] {
            ""})]
    [View("ComputerE", new string[] {
            "SerialNumber as \'Serial number\'",
            "ManufactureDate as \'Manufacture date\'",
            "Type as \'Type\'",
            "Description as \'Description\'"})]
    [AssociatedDetailViewAttribute("ComputerE", "ComputerPart", "ComputerPartE", true, "", "Computer part", true, new string[] {
            ""})]
    [View("ComputerL", new string[] {
            "SerialNumber as \'Serial number\'",
            "ManufactureDate as \'Manufacture date\'",
            "Type as \'Type\'",
            "Description as \'Description\'",
            "CreateTime as \'Создание\'",
            "Creator as \'Создатель\'",
            "EditTime as \'Редактирование\'",
            "Editor as \'Редактор\'"})]
    public class Computer : ICSSoft.STORMNET.DataObject, IDataObjectWithAuditFields
    {
        
        private string fSerialNumber;
        
        private ICSSoft.STORMNET.UserDataTypes.NullableDateTime fManufactureDate;
        
        private IIS.MyTestApplicationEmber.ComputerType fType;
        
        private string fDescription;
        
        private string fDescription3;
        
        private string fDescription4;
        
        private System.Nullable<System.DateTime> fCreateTime;
        
        private string fCreator;
        
        private System.Nullable<System.DateTime> fEditTime;
        
        private string fEditor;
        
        private IIS.MyTestApplicationEmber.DetailArrayOfComputerPart fComputerPart;
        
        //  *** Start programmer edit section *** (Computer CustomMembers)

        //  *** End programmer edit section *** (Computer CustomMembers)

        
        /// <summary>
        /// SerialNumber.
        /// </summary>
        //  *** Start programmer edit section *** (Computer.SerialNumber CustomAttributes)

        //  *** End programmer edit section *** (Computer.SerialNumber CustomAttributes)
        [StrLen(255)]
        public virtual string SerialNumber
        {
            get
            {
                //  *** Start programmer edit section *** (Computer.SerialNumber Get start)

                //  *** End programmer edit section *** (Computer.SerialNumber Get start)
                string result = this.fSerialNumber;
                //  *** Start programmer edit section *** (Computer.SerialNumber Get end)

                //  *** End programmer edit section *** (Computer.SerialNumber Get end)
                return result;
            }
            set
            {
                //  *** Start programmer edit section *** (Computer.SerialNumber Set start)

                //  *** End programmer edit section *** (Computer.SerialNumber Set start)
                this.fSerialNumber = value;
                //  *** Start programmer edit section *** (Computer.SerialNumber Set end)

                //  *** End programmer edit section *** (Computer.SerialNumber Set end)
            }
        }
        
        /// <summary>
        /// ManufactureDate.
        /// </summary>
        //  *** Start programmer edit section *** (Computer.ManufactureDate CustomAttributes)

        //  *** End programmer edit section *** (Computer.ManufactureDate CustomAttributes)
        public virtual ICSSoft.STORMNET.UserDataTypes.NullableDateTime ManufactureDate
        {
            get
            {
                //  *** Start programmer edit section *** (Computer.ManufactureDate Get start)

                //  *** End programmer edit section *** (Computer.ManufactureDate Get start)
                ICSSoft.STORMNET.UserDataTypes.NullableDateTime result = this.fManufactureDate;
                //  *** Start programmer edit section *** (Computer.ManufactureDate Get end)

                //  *** End programmer edit section *** (Computer.ManufactureDate Get end)
                return result;
            }
            set
            {
                //  *** Start programmer edit section *** (Computer.ManufactureDate Set start)

                //  *** End programmer edit section *** (Computer.ManufactureDate Set start)
                this.fManufactureDate = value;
                //  *** Start programmer edit section *** (Computer.ManufactureDate Set end)

                //  *** End programmer edit section *** (Computer.ManufactureDate Set end)
            }
        }
        
        /// <summary>
        /// Type.
        /// </summary>
        //  *** Start programmer edit section *** (Computer.Type CustomAttributes)

        //  *** End programmer edit section *** (Computer.Type CustomAttributes)
        public virtual IIS.MyTestApplicationEmber.ComputerType Type
        {
            get
            {
                //  *** Start programmer edit section *** (Computer.Type Get start)

                //  *** End programmer edit section *** (Computer.Type Get start)
                IIS.MyTestApplicationEmber.ComputerType result = this.fType;
                //  *** Start programmer edit section *** (Computer.Type Get end)

                //  *** End programmer edit section *** (Computer.Type Get end)
                return result;
            }
            set
            {
                //  *** Start programmer edit section *** (Computer.Type Set start)

                //  *** End programmer edit section *** (Computer.Type Set start)
                this.fType = value;
                //  *** Start programmer edit section *** (Computer.Type Set end)

                //  *** End programmer edit section *** (Computer.Type Set end)
            }
        }
        
        /// <summary>
        /// Description.
        /// </summary>
        //  *** Start programmer edit section *** (Computer.Description CustomAttributes)

        //  *** End programmer edit section *** (Computer.Description CustomAttributes)
        public virtual string Description
        {
            get
            {
                //  *** Start programmer edit section *** (Computer.Description Get start)

                //  *** End programmer edit section *** (Computer.Description Get start)
                string result = this.fDescription;
                //  *** Start programmer edit section *** (Computer.Description Get end)

                //  *** End programmer edit section *** (Computer.Description Get end)
                return result;
            }
            set
            {
                //  *** Start programmer edit section *** (Computer.Description Set start)

                //  *** End programmer edit section *** (Computer.Description Set start)
                this.fDescription = value;
                //  *** Start programmer edit section *** (Computer.Description Set end)

                //  *** End programmer edit section *** (Computer.Description Set end)
            }
        }
        
        /// <summary>
        /// Description3.
        /// </summary>
        //  *** Start programmer edit section *** (Computer.Description3 CustomAttributes)

        //  *** End programmer edit section *** (Computer.Description3 CustomAttributes)
        public virtual string Description3
        {
            get
            {
                //  *** Start programmer edit section *** (Computer.Description3 Get start)

                //  *** End programmer edit section *** (Computer.Description3 Get start)
                string result = this.fDescription3;
                //  *** Start programmer edit section *** (Computer.Description3 Get end)

                //  *** End programmer edit section *** (Computer.Description3 Get end)
                return result;
            }
            set
            {
                //  *** Start programmer edit section *** (Computer.Description3 Set start)

                //  *** End programmer edit section *** (Computer.Description3 Set start)
                this.fDescription3 = value;
                //  *** Start programmer edit section *** (Computer.Description3 Set end)

                //  *** End programmer edit section *** (Computer.Description3 Set end)
            }
        }
        
        /// <summary>
        /// Description4.
        /// </summary>
        //  *** Start programmer edit section *** (Computer.Description4 CustomAttributes)

        //  *** End programmer edit section *** (Computer.Description4 CustomAttributes)
        public virtual string Description4
        {
            get
            {
                //  *** Start programmer edit section *** (Computer.Description4 Get start)

                //  *** End programmer edit section *** (Computer.Description4 Get start)
                string result = this.fDescription4;
                //  *** Start programmer edit section *** (Computer.Description4 Get end)

                //  *** End programmer edit section *** (Computer.Description4 Get end)
                return result;
            }
            set
            {
                //  *** Start programmer edit section *** (Computer.Description4 Set start)

                //  *** End programmer edit section *** (Computer.Description4 Set start)
                this.fDescription4 = value;
                //  *** Start programmer edit section *** (Computer.Description4 Set end)

                //  *** End programmer edit section *** (Computer.Description4 Set end)
            }
        }
        
        /// <summary>
        /// Время создания объекта.
        /// </summary>
        //  *** Start programmer edit section *** (Computer.CreateTime CustomAttributes)

        //  *** End programmer edit section *** (Computer.CreateTime CustomAttributes)
        public virtual System.Nullable<System.DateTime> CreateTime
        {
            get
            {
                //  *** Start programmer edit section *** (Computer.CreateTime Get start)

                //  *** End programmer edit section *** (Computer.CreateTime Get start)
                System.Nullable<System.DateTime> result = this.fCreateTime;
                //  *** Start programmer edit section *** (Computer.CreateTime Get end)

                //  *** End programmer edit section *** (Computer.CreateTime Get end)
                return result;
            }
            set
            {
                //  *** Start programmer edit section *** (Computer.CreateTime Set start)

                //  *** End programmer edit section *** (Computer.CreateTime Set start)
                this.fCreateTime = value;
                //  *** Start programmer edit section *** (Computer.CreateTime Set end)

                //  *** End programmer edit section *** (Computer.CreateTime Set end)
            }
        }
        
        /// <summary>
        /// Создатель объекта.
        /// </summary>
        //  *** Start programmer edit section *** (Computer.Creator CustomAttributes)

        //  *** End programmer edit section *** (Computer.Creator CustomAttributes)
        [StrLen(255)]
        public virtual string Creator
        {
            get
            {
                //  *** Start programmer edit section *** (Computer.Creator Get start)

                //  *** End programmer edit section *** (Computer.Creator Get start)
                string result = this.fCreator;
                //  *** Start programmer edit section *** (Computer.Creator Get end)

                //  *** End programmer edit section *** (Computer.Creator Get end)
                return result;
            }
            set
            {
                //  *** Start programmer edit section *** (Computer.Creator Set start)

                //  *** End programmer edit section *** (Computer.Creator Set start)
                this.fCreator = value;
                //  *** Start programmer edit section *** (Computer.Creator Set end)

                //  *** End programmer edit section *** (Computer.Creator Set end)
            }
        }
        
        /// <summary>
        /// Время последнего редактирования объекта.
        /// </summary>
        //  *** Start programmer edit section *** (Computer.EditTime CustomAttributes)

        //  *** End programmer edit section *** (Computer.EditTime CustomAttributes)
        public virtual System.Nullable<System.DateTime> EditTime
        {
            get
            {
                //  *** Start programmer edit section *** (Computer.EditTime Get start)

                //  *** End programmer edit section *** (Computer.EditTime Get start)
                System.Nullable<System.DateTime> result = this.fEditTime;
                //  *** Start programmer edit section *** (Computer.EditTime Get end)

                //  *** End programmer edit section *** (Computer.EditTime Get end)
                return result;
            }
            set
            {
                //  *** Start programmer edit section *** (Computer.EditTime Set start)

                //  *** End programmer edit section *** (Computer.EditTime Set start)
                this.fEditTime = value;
                //  *** Start programmer edit section *** (Computer.EditTime Set end)

                //  *** End programmer edit section *** (Computer.EditTime Set end)
            }
        }
        
        /// <summary>
        /// Последний редактор объекта.
        /// </summary>
        //  *** Start programmer edit section *** (Computer.Editor CustomAttributes)

        //  *** End programmer edit section *** (Computer.Editor CustomAttributes)
        [StrLen(255)]
        public virtual string Editor
        {
            get
            {
                //  *** Start programmer edit section *** (Computer.Editor Get start)

                //  *** End programmer edit section *** (Computer.Editor Get start)
                string result = this.fEditor;
                //  *** Start programmer edit section *** (Computer.Editor Get end)

                //  *** End programmer edit section *** (Computer.Editor Get end)
                return result;
            }
            set
            {
                //  *** Start programmer edit section *** (Computer.Editor Set start)

                //  *** End programmer edit section *** (Computer.Editor Set start)
                this.fEditor = value;
                //  *** Start programmer edit section *** (Computer.Editor Set end)

                //  *** End programmer edit section *** (Computer.Editor Set end)
            }
        }
        
        /// <summary>
        /// Computer.
        /// </summary>
        //  *** Start programmer edit section *** (Computer.ComputerPart CustomAttributes)

        //  *** End programmer edit section *** (Computer.ComputerPart CustomAttributes)
        public virtual IIS.MyTestApplicationEmber.DetailArrayOfComputerPart ComputerPart
        {
            get
            {
                //  *** Start programmer edit section *** (Computer.ComputerPart Get start)

                //  *** End programmer edit section *** (Computer.ComputerPart Get start)
                if ((this.fComputerPart == null))
                {
                    this.fComputerPart = new IIS.MyTestApplicationEmber.DetailArrayOfComputerPart(this);
                }
                IIS.MyTestApplicationEmber.DetailArrayOfComputerPart result = this.fComputerPart;
                //  *** Start programmer edit section *** (Computer.ComputerPart Get end)

                //  *** End programmer edit section *** (Computer.ComputerPart Get end)
                return result;
            }
            set
            {
                //  *** Start programmer edit section *** (Computer.ComputerPart Set start)

                //  *** End programmer edit section *** (Computer.ComputerPart Set start)
                this.fComputerPart = value;
                //  *** Start programmer edit section *** (Computer.ComputerPart Set end)

                //  *** End programmer edit section *** (Computer.ComputerPart Set end)
            }
        }
        
        /// <summary>
        /// Class views container.
        /// </summary>
        public class Views
        {
            
            /// <summary>
            /// "AuditView" view.
            /// </summary>
            public static ICSSoft.STORMNET.View AuditView
            {
                get
                {
                    return ICSSoft.STORMNET.Information.GetView("AuditView", typeof(IIS.MyTestApplicationEmber.Computer));
                }
            }
            
            /// <summary>
            /// "ComputerE" view.
            /// </summary>
            public static ICSSoft.STORMNET.View ComputerE
            {
                get
                {
                    return ICSSoft.STORMNET.Information.GetView("ComputerE", typeof(IIS.MyTestApplicationEmber.Computer));
                }
            }
            
            /// <summary>
            /// "ComputerL" view.
            /// </summary>
            public static ICSSoft.STORMNET.View ComputerL
            {
                get
                {
                    return ICSSoft.STORMNET.Information.GetView("ComputerL", typeof(IIS.MyTestApplicationEmber.Computer));
                }
            }
        }
        
        /// <summary>
        /// Audit class settings.
        /// </summary>
        public class AuditSettings
        {
            
            /// <summary>
            /// Включён ли аудит для класса.
            /// </summary>
            public static bool AuditEnabled = true;
            
            /// <summary>
            /// Использовать имя представления для аудита по умолчанию.
            /// </summary>
            public static bool UseDefaultView = false;
            
            /// <summary>
            /// Включён ли аудит операции чтения.
            /// </summary>
            public static bool SelectAudit = false;
            
            /// <summary>
            /// Имя представления для аудирования операции чтения.
            /// </summary>
            public static string SelectAuditViewName = "AuditView";
            
            /// <summary>
            /// Включён ли аудит операции создания.
            /// </summary>
            public static bool InsertAudit = true;
            
            /// <summary>
            /// Имя представления для аудирования операции создания.
            /// </summary>
            public static string InsertAuditViewName = "AuditView";
            
            /// <summary>
            /// Включён ли аудит операции изменения.
            /// </summary>
            public static bool UpdateAudit = false;
            
            /// <summary>
            /// Имя представления для аудирования операции изменения.
            /// </summary>
            public static string UpdateAuditViewName = "AuditView";
            
            /// <summary>
            /// Включён ли аудит операции удаления.
            /// </summary>
            public static bool DeleteAudit = true;
            
            /// <summary>
            /// Имя представления для аудирования операции удаления.
            /// </summary>
            public static string DeleteAuditViewName = "AuditView";
            
            /// <summary>
            /// Путь к форме просмотра результатов аудита.
            /// </summary>
            public static string FormUrl = "";
            
            /// <summary>
            /// Режим записи данных аудита (синхронный или асинхронный).
            /// </summary>
            public static ICSSoft.STORMNET.Business.Audit.Objects.tWriteMode WriteMode = ICSSoft.STORMNET.Business.Audit.Objects.tWriteMode.Synchronous;
            
            /// <summary>
            /// Максимальная длина сохраняемого значения поля (если 0, то строка обрезаться не будет).
            /// </summary>
            public static int PrunningLength = 0;
            
            /// <summary>
            /// Показывать ли пользователям в изменениях первичные ключи.
            /// </summary>
            public static bool ShowPrimaryKey = false;
            
            /// <summary>
            /// Сохранять ли старое значение.
            /// </summary>
            public static bool KeepOldValue = true;
            
            /// <summary>
            /// Сжимать ли сохраняемые значения.
            /// </summary>
            public static bool Compress = false;
            
            /// <summary>
            /// Сохранять ли все значения атрибутов, а не только изменяемые.
            /// </summary>
            public static bool KeepAllValues = false;
        }
    }
}
