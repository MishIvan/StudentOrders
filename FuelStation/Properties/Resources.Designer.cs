﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace FuelStation.Properties {
    using System;
    
    
    /// <summary>
    ///   Класс ресурса со строгой типизацией для поиска локализованных строк и т.д.
    /// </summary>
    // Этот класс создан автоматически классом StronglyTypedResourceBuilder
    // с помощью такого средства, как ResGen или Visual Studio.
    // Чтобы добавить или удалить член, измените файл .ResX и снова запустите ResGen
    // с параметром /str или перестройте свой проект VS.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "16.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class Resources {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Resources() {
        }
        
        /// <summary>
        ///   Возвращает кэшированный экземпляр ResourceManager, использованный этим классом.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("FuelStation.Properties.Resources", typeof(Resources).Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        /// <summary>
        ///   Перезаписывает свойство CurrentUICulture текущего потока для всех
        ///   обращений к ресурсу с помощью этого класса ресурса со строгой типизацией.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   Поиск локализованного ресурса типа System.Drawing.Bitmap.
        /// </summary>
        internal static System.Drawing.Bitmap add {
            get {
                object obj = ResourceManager.GetObject("add", resourceCulture);
                return ((System.Drawing.Bitmap)(obj));
            }
        }
        
        /// <summary>
        ///   Ищет локализованную строку, похожую на Неверный формат количества.
        /// </summary>
        internal static string COUNT_ERROR {
            get {
                return ResourceManager.GetString("COUNT_ERROR", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Поиск локализованного ресурса типа System.Drawing.Bitmap.
        /// </summary>
        internal static System.Drawing.Bitmap delete {
            get {
                object obj = ResourceManager.GetObject("delete", resourceCulture);
                return ((System.Drawing.Bitmap)(obj));
            }
        }
        
        /// <summary>
        ///   Поиск локализованного ресурса типа System.Drawing.Bitmap.
        /// </summary>
        internal static System.Drawing.Bitmap edit {
            get {
                object obj = ResourceManager.GetObject("edit", resourceCulture);
                return ((System.Drawing.Bitmap)(obj));
            }
        }
        
        /// <summary>
        ///   Ищет локализованную строку, похожую на Ввод пустого значения для количества недопустим.
        /// </summary>
        internal static string EMPTY_COUNT {
            get {
                return ResourceManager.GetString("EMPTY_COUNT", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Ищет локализованную строку, похожую на Ввод пустого значения для цены недопустим.
        /// </summary>
        internal static string EMPTY_PRICE {
            get {
                return ResourceManager.GetString("EMPTY_PRICE", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Ищет локализованную строку, похожую на Значение наименования не должно быть пустым.
        /// </summary>
        internal static string NAME_EMPTY {
            get {
                return ResourceManager.GetString("NAME_EMPTY", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Ищет локализованную строку, похожую на {0}: не хватает остатков на складе.
        /// </summary>
        internal static string NOT_SUFFUCIENT_RESIDUE {
            get {
                return ResourceManager.GetString("NOT_SUFFUCIENT_RESIDUE", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Ищет локализованную строку, похожую на Неверный формат цены.
        /// </summary>
        internal static string PRICE_ERROR {
            get {
                return ResourceManager.GetString("PRICE_ERROR", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Ищет локализованную строку, похожую на Менеджер {0} уже есть в списке менеджеров.
        /// </summary>
        internal static string USER_ALREADY_EXISTS {
            get {
                return ResourceManager.GetString("USER_ALREADY_EXISTS", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Ищет локализованную строку, похожую на {0}: нет такого менеджера.
        /// </summary>
        internal static string USER_NOT_EXISTS {
            get {
                return ResourceManager.GetString("USER_NOT_EXISTS", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Ищет локализованную строку, похожую на Автомобиль с госномером {0} находится в журнале продаж. Его нельзя удалять.
        /// </summary>
        internal static string VEHICLE_IN_SAILING {
            get {
                return ResourceManager.GetString("VEHICLE_IN_SAILING", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Ищет локализованную строку, похожую на {0}: нет ТС с таким гос. номером.
        /// </summary>
        internal static string VEHICLE_NOT_EXISTS {
            get {
                return ResourceManager.GetString("VEHICLE_NOT_EXISTS", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Ищет локализованную строку, похожую на Гос. номер или наименование ТС не должны быть пустыми.
        /// </summary>
        internal static string VEHICLE_PARAMS_EMPTY {
            get {
                return ResourceManager.GetString("VEHICLE_PARAMS_EMPTY", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Ищет локализованную строку, похожую на ГСМ с наименованием {0} уже есть в списке номенклатуры ГСМ.
        /// </summary>
        internal static string WARE_ALREADY_EXISTS {
            get {
                return ResourceManager.GetString("WARE_ALREADY_EXISTS", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Ищет локализованную строку, похожую на ГСМ {0} нельязя удалять. Для него был приход или он участвовоал в продажах.
        /// </summary>
        internal static string WARE_IN_MOVE {
            get {
                return ResourceManager.GetString("WARE_IN_MOVE", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Ищет локализованную строку, похожую на {0}: нет такого наименования ГСМ.
        /// </summary>
        internal static string WARE_NOT_EXISTS {
            get {
                return ResourceManager.GetString("WARE_NOT_EXISTS", resourceCulture);
            }
        }
    }
}
