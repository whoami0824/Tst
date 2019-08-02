using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;

namespace RotatingViscometer.Nithons._190724.Lan
{
    /// <summary>
    /// [14种语言类型]
    /// </summary>
    class Multi_Language
    {
        #region [字体 * 3] 字体样式

        /// <summary>
        /// [字体]
        /// 8号默认字体
        /// </summary>
        public Font[] Fn8 = {
            new Font("Times New Roman",8.0f),
            new Font("微软雅黑",8.0f),
            new Font("微软雅黑",8.0f),
            new Font("微软雅黑",8.0f),
            new Font("微软雅黑",8.0f),
            new Font("Times New Roman",8.0f),
            new Font("Times New Roman",8.0f),
            new Font("Times New Roman",8.0f),
            new Font("Times New Roman",8.0f),
            new Font("Times New Roman",8.0f),
            new Font("Times New Roman",8.0f),
            new Font("Times New Roman",8.0f),
            new Font("Times New Roman",8.0f),
            new Font("Times New Roman",8.0f)
        };

        /// <summary>
        /// [字体]
        /// 9号默认字体
        /// </summary>
        public Font[] Fn9 = {
            new Font("Times New Roman",9.0f),
            new Font("微软雅黑",9.0f),
            new Font("微软雅黑",9.0f),
            new Font("微软雅黑",9.0f),
            new Font("微软雅黑",9.0f),
            new Font("Times New Roman",9.0f),
            new Font("Times New Roman",9.0f),
            new Font("Times New Roman",9.0f),
            new Font("Times New Roman",9.0f),
            new Font("Times New Roman",9.0f),
            new Font("Times New Roman",9.0f),
            new Font("Times New Roman",9.0f),
            new Font("Times New Roman",9.0f),
            new Font("Times New Roman",9.0f)
        };

        /// <summary>
        /// [字体]
        /// 9号默认字体加粗
        /// </summary>
        public Font[] Fn9b = {
            new Font("Times New Roman",9.0f,FontStyle.Bold),
            new Font("微软雅黑",9.0f,FontStyle.Bold),
            new Font("微软雅黑",9.0f,FontStyle.Bold),
            new Font("微软雅黑",9.0f,FontStyle.Bold),
            new Font("微软雅黑",9.0f,FontStyle.Bold),
            new Font("Times New Roman",9.0f,FontStyle.Bold),
            new Font("Times New Roman",9.0f,FontStyle.Bold),
            new Font("Times New Roman",9.0f,FontStyle.Bold),
            new Font("Times New Roman",9.0f,FontStyle.Bold),
            new Font("Times New Roman",9.0f,FontStyle.Bold),
            new Font("Times New Roman",9.0f,FontStyle.Bold),
            new Font("Times New Roman",9.0f,FontStyle.Bold),
            new Font("Times New Roman",9.0f,FontStyle.Bold),
            new Font("Times New Roman",9.0f,FontStyle.Bold)
        };

        /// <summary>
        /// [字体]
        /// 10号字体加粗
        /// </summary>
        public Font[] Fn10b = {
            new Font("Times New Roman",10.0f,FontStyle.Bold),
            new Font("微软雅黑",10.0f,FontStyle.Bold),
            new Font("微软雅黑",10.0f,FontStyle.Bold),
            new Font("微软雅黑",10.0f,FontStyle.Bold),
            new Font("微软雅黑",10.0f,FontStyle.Bold),
            new Font("Times New Roman",10.0f,FontStyle.Bold),
            new Font("Times New Roman",10.0f,FontStyle.Bold),
            new Font("Times New Roman",10.0f,FontStyle.Bold),
            new Font("Times New Roman",10.0f,FontStyle.Bold),
            new Font("Times New Roman",10.0f,FontStyle.Bold),
            new Font("Times New Roman",10.0f,FontStyle.Bold),
            new Font("Times New Roman",10.0f,FontStyle.Bold),
            new Font("Times New Roman",10.0f,FontStyle.Bold),
            new Font("Times New Roman",10.0f,FontStyle.Bold)
        };

        #endregion


        #region [提示 * 5] 提示信息类

        /// <summary>
        /// [提示]
        /// 错误
        /// </summary>
        public string[] Error = {
            "",
            "",
            "错误",
            "",
            "",
            "",
            "ошибка",
            "Error",
            "",
            "",
            "",
            "",
            "",
            ""
        };

        /// <summary>
        /// [提示]
        /// 成功
        /// </summary>
        public string[] Success = {
            "",
            "",
            "成功",
            "",
            "",
            "",
            "успех",
            "Success",
            "",
            "",
            "",
            "",
            "",
            ""
        };

        /// <summary>
        /// [提示]
        /// 出了点问题
        /// </summary>
        public string[] Exception = {
            "",
            "",
            "出了点问题！",
            "",
            "出了點問題！",
            "",
            "Что-то пошло не так!",
            "Something went wrong!",
            "",
            "",
            "",
            "",
            "",
            ""
        };

        /// <summary>
        /// [提示]
        /// 输入存在错误
        /// </summary>
        public string[] InputError = {
            "",
            "",
            "输入存在错误！",
            "",
            "",
            "",
            "Ошибка ввода!",
            "Input error!",
            "",
            "",
            "",
            "",
            "",
            ""
        };

        /// <summary>
        /// [提示]
        /// 参数更新成功
        /// </summary>
        public string[] ParmUpdate = {
            "",
            "",
            "参数更新成功！",
            "",
            "",
            "",
            "Обновление параметра выполнено успешно!",
            "Parameter update succeeded!",
            "",
            "",
            "",
            "",
            "",
            ""
        };

        #endregion

        #region [标签 * 11] 菜单控件标签类

        /// <summary>
        /// [标签]
        /// 文件
        /// </summary>
        public string[] File = {
            "",
            "",
            "文件",
            "",
            "文件",
            "",
            "файл",
            "File",
            "",
            "",
            "",
            "",
            "",
            ""
        };

        /// <summary>
        /// [标签]
        /// 新建
        /// </summary>
        public string[] New = {
            "",
            "",
            "新建",
            "",
            "新建",
            "",
            "новый",
            "New",
            "",
            "",
            "",
            "",
            "",
            ""
        };

        /// <summary>
        /// [标签]
        /// 退出
        /// </summary>
        public string[] Exit = {
            "",
            "",
            "退出",
            "",
            "退出",
            "",
            "выход",
            "Exit",
            "",
            "",
            "",
            "",
            "",
            ""
        };

        /// <summary>
        /// [标签]
        /// 测试
        /// </summary>
        public string[] Test = {
            "",
            "",
            "测试",
            "",
            "測試",
            "",
            "тест",
            "Test",
            "",
            "",
            "",
            "",
            "",
            ""
        };

        /// <summary>
        /// [标签]
        /// 开始
        /// </summary>
        public string[] Start = {
            "",
            "",
            "开始",
            "",
            "開始",
            "",
            "начать",
            "Start",
            "",
            "",
            "",
            "",
            "",
            ""
        };

        /// <summary>
        /// [标签]
        /// 暂停/继续
        /// </summary>
        public string[] SuspCont = {
            "",
            "",
            "暂停/继续",
            "",
            "暫停/繼續",
            "",
            "Пауза / Возобновление",
            "Suspend / Continue",
            "",
            "",
            "",
            "",
            "",
            ""
        };

        /// <summary>
        /// [标签]
        /// 结束
        /// </summary>
        public string[] End = {
            "",
            "",
            "结束",
            "",
            "結束",
            "",
            "Конец",
            "End",
            "",
            "",
            "",
            "",
            "",
            ""
        };

        /// <summary>
        /// [标签]
        /// 参数配置
        /// </summary>
        public string[] ParmConf = {
            "",
            "",
            "参数配置",
            "",
            "參數配置",
            "",
            "Конфигурация параметров",
            "Parameter Configuration",
            "",
            "",
            "",
            "",
            "",
            ""
        };

        /// <summary>
        /// [标签]
        /// 工具
        /// </summary>
        public string[] Tool = {
            "",
            "",
            "工具",
            "",
            "工具",
            "",
            "инструмент",
            "Tool",
            "",
            "",
            "",
            "",
            "",
            ""
        };

        /// <summary>
        /// [标签]
        /// 语言
        /// </summary>
        public string[] Lang = {
            "",
            "",
            "语言",
            "",
            "語言",
            "",
            "язык",
            "Language",
            "",
            "",
            "",
            "",
            "",
            ""
        };

        /// <summary>
        /// [标签]
        /// 帮助
        /// </summary>
        public string[] Help = {
            "",
            "",
            "帮助",
            "",
            "幫助",
            "",
            "помощь",
            "Help",
            "",
            "",
            "",
            "",
            "",
            ""
        };

        /// <summary>
        /// [标签]
        /// 关于
        /// </summary>
        public string[] About = {
            "",
            "",
            "关于",
            "",
            "",
            "",
            "Около",
            "About",
            "",
            "",
            "",
            "",
            "",
            ""
        };

        /// <summary>
        /// [标签]
        /// 了解更多
        /// </summary>
        public string[] More = {
            "",
            "",
            "了解更多...",
            "",
            "",
            "",
            "Узнайте больше ...",
            "Learn More...",
            "",
            "",
            "",
            "",
            "",
            ""
        };

        #endregion

        #region [标签 * 3] 工具栏控件标签类

        /// <summary>
        /// [标签]
        /// 测试名称
        /// </summary>
        public string[] TstName = {
            "",
            "",
            "测试名称",
            "",
            "",
            "",
            "Название теста",
            "Test Name",
            "",
            "",
            "",
            "",
            "",
            ""
        };

        /// <summary>
        /// [标签]
        /// 主检人
        /// </summary>
        public string[] MainCensor = {
            "",
            "",
            "主检人",
            "",
            "",
            "",
            "Главный экзаменатор",
            "Main Censor",
            "",
            "",
            "",
            "",
            "",
            ""
        };

        /// <summary>
        /// [标签]
        /// 测试日期
        /// </summary>
        public string[] TstDate = {
            "",
            "",
            "日期",
            "",
            "",
            "",
            "дата",
            "Date",
            "",
            "",
            "",
            "",
            "",
            ""
        };

        /// <summary>
        /// [标签]
        /// 测试备注
        /// </summary>
        public string[] TstNote = {
            "",
            "",
            "测试备注",
            "",
            "",
            "",
            "Тестовая заметка",
            "Test Note",
            "",
            "",
            "",
            "",
            "",
            ""
        };

        /// <summary>
        /// [标签]
        /// 默认标题
        /// </summary>
        public string[] DefTitle = {
            "",
            "",
            "默认标题",
            "",
            "",
            "",
            "Название по умолчанию",
            "Default title",
            "",
            "",
            "",
            "",
            "",
            ""
        };

        /// <summary>
        /// [标签]
        /// 暂无
        /// </summary>
        public string[] NotSet = {
            "",
            "",
            "暂无",
            "",
            "",
            "",
            "Не установлено",
            "Not set",
            "",
            "",
            "",
            "",
            "",
            ""
        };

        #endregion

        #region [标签 * 1] 选项卡控件标签类

        /// <summary>
        /// [标签]
        /// 设备
        /// </summary>
        public string[] Dev = {
            "",
            "",
            "设备",
            "",
            "",
            "",
            "оборудование",
            "Device",
            "",
            "",
            "",
            "",
            "",
            ""
        };

        #endregion

        #region [标签 * 3] 组控件标签

        /// <summary>
        /// [标签]
        /// 测试状态
        /// </summary>
        public string[] TstStatus = {
            "",
            "",
            "测试状态",
            "",
            "",
            "",
            "Тестовый статус",
            "Test Status",
            "",
            "",
            "",
            "",
            "",
            ""
        };

        /// <summary>
        /// [标签]
        /// 测试模式
        /// </summary>
        public string[] TstMode = {
            "",
            "",
            "测试模式",
            "",
            "",
            "",
            "Тестовый режим",
            "Test Mode",
            "",
            "",
            "",
            "",
            "",
            ""
        };

        /// <summary>
        /// [特殊标签]
        /// 两点法
        /// </summary>
        public string[] TheSecondPointMethod = {
            "",
            "",
            "两点法",
            "",
            "",
            "",
            "Второй пункт метод",
            "The Second Point Method",
            "",
            "",
            "",
            "",
            "",
            ""
        };

        #endregion

        #region [标签 * 1] 欢迎词

        /// <summary>
        /// [特殊标签]
        /// 欢迎词
        /// </summary>
        public string[] Welcome = {
            "",
            "",
            "欢迎使用宁赛科技旋转粘度计数据采集软件！",
            "",
            "",
            "",
            "Добро пожаловать в программу сбора данных для вращающегося вискозиметра Nithons Technology!",
            "Welcome to Nithons Technology Rotating Viscometer Data Acquisition Software!",
            "",
            "",
            "",
            "",
            "",
            ""
        };

        #endregion

        #region [标签 * 2] 组内标签

        /// <summary>
        /// [标签]
        /// 图标a标题
        /// </summary>
        public string[] ChartTitleA = {
             "",
            "",
            "剪切应力和剪切速率在线性坐标轴上的曲线",
            "",
            "",
            "",
            "Напряжение сдвига и кривая скорости сдвига на линейной оси координат",
            "Shear Stress and Shear Rate Curve on Linear Coordinate Axis",
            "",
            "",
            "",
            "",
            "",
            ""
        };

        /// <summary>
        /// [标签]
        /// 图标b标题
        /// </summary>
        public string[] ChartTitleB = {
             "",
            "",
            "剪切应力和剪切速率在对数坐标轴上的曲线",
            "",
            "",
            "",
            "Кривые напряжения сдвига и скорости сдвига на логарифмической оси",
            "Curves of Shear Stress and Shear Rate on Logarithmic Axis",
            "",
            "",
            "",
            "",
            "",
            ""
        };

        #endregion

        #region [标签 * 2] 按钮标签类

        /// <summary>
        /// [标签]
        /// 提交
        /// </summary>
        public string[] SubmitBtn = {
            "",
            "",
            "提交",
            "",
            "",
            "",
            "Отправить",
            "Submit",
            "",
            "",
            "",
            "",
            "",
            ""
        };

        /// <summary>
        /// [标签]
        /// 返回
        /// </summary>
        public string[] ReturnBtn = {
            "",
            "",
            "返回",
            "",
            "",
            "",
            "Вернуть",
            "Return",
            "",
            "",
            "",
            "",
            "",
            ""
        };

        #endregion

        #region [标签 * 2] 基础参数标签类

        /// <summary>
        /// [标签]
        /// 设备地址
        /// </summary>
        public string[] IpAddr = {
            "",
            "",
            "设备地址",
            "",
            "",
            "",
            "Адрес устройства",
            "Device Address",
            "",
            "",
            "",
            "",
            "",
            ""
        };

        /// <summary>
        /// [标签]
        /// 端口范围
        /// </summary>
        public string[] PortRange = {
            "",
            "",
            "端口范围",
            "",
            "",
            "",
            "Диапазон портов",
            "Port Range",
            "",
            "",
            "",
            "",
            "",
            ""
        };

        #endregion

        #region [标签 * 3] 扫描进度

        /// <summary>
        /// [标签]
        /// 扫描进度标题
        /// </summary>
        public string[] ScanHeader = {
            "",
            "",
            "设备扫描中，请稍候...",
            "",
            "",
            "",
            "Пожалуйста, подождите, пока устройство сканирует ...",
            "Please wait while the device is scanning...",
            "",
            "",
            "",
            "",
            "",
            ""
        };

        /// <summary>
        /// [标签]
        /// 扫描进度提示1
        /// </summary>
        public string[] ScanPrompt1 = {
            "",
            "",
            "正在进行目标设备扫描（0/4）...",
            "",
            "",
            "",
            "Идет сканирование целевого устройства (0/4) ...",
            "Target device scan (0/4) is in progress...",
            "",
            "",
            "",
            "",
            "",
            ""
        };

        /// <summary>
        /// [标签]
        /// 扫描进度提示2
        /// </summary>
        public string[] ScanPrompt2 = {
            "",
            "",
            "正在进行目标设备端口连接验证（0/40）...",
            "",
            "",
            "",
            "Идет проверка соединения порта целевого устройства (0/40) ...",
            "Target device port connection verification (0/40) is in progress...",
            "",
            "",
            "",
            "",
            "",
            ""
        };

        #endregion

        #region [标签 * 4] 测试状态

        /// <summary>
        /// 测试未开始
        /// </summary>
        public string[] TstNotStart = {
            "",
            "",
            "测试未开始",
            "",
            "",
            "",
            "Тест не начался",
            "Test not started",
            "",
            "",
            "",
            "",
            "",
            ""
        };

        /// <summary>
        /// 测试进行中
        /// </summary>
        public string[] TstInProg = {
            "",
            "",
            "测试进行中",
            "",
            "",
            "",
            "Идет тестирование",
            "Testing in progress",
            "",
            "",
            "",
            "",
            "",
            ""
        };

        /// <summary>
        /// 测试已完成
        /// </summary>
        public string[] TstComp = {
            "",
            "",
            "测试已完成",
            "",
            "",
            "",
            "Тест завершен",
            "Test completed",
            "",
            "",
            "",
            "",
            "",
            ""
        };

        /// <summary>
        /// 测试已终止
        /// </summary>
        public string[] TstTerm = {
            "",
            "",
            "测试已终止",
            "",
            "",
            "",
            "Тест прекращен",
            "Test terminated",
            "",
            "",
            "",
            "",
            "",
            ""
        };

        #endregion

        #region [标签 * 7] 测试模式

        /// <summary>
        /// 自动12速
        /// </summary>
        public string[] AutoSpeed12 = {
            "",
            "",
            "自动12速",
            "",
            "",
            "",
            "Автоматическая 12 скорость",
            "Automatic 12 speed",
            "",
            "",
            "",
            "",
            "",
            ""
        };

        /// <summary>
        /// 自动6速
        /// </summary>
        public string[] AutoSpeed6 = {
            "",
            "",
            "自动6速",
            "",
            "",
            "",
            "Автоматическая 6 скорость",
            "Automatic 6 speed",
            "",
            "",
            "",
            "",
            "",
            ""
        };

        /// <summary>
        /// 自动5速
        /// </summary>
        public string[] AutoSpeed5 = {
            "",
            "",
            "自动5速",
            "",
            "",
            "",
            "Автоматическая 5 скорость",
            "Automatic 5 speed",
            "",
            "",
            "",
            "",
            "",
            ""
        };

        /// <summary>
        /// 胶凝12速
        /// </summary>
        public string[] GelSpeed12 = {
            "",
            "",
            "胶凝12速",
            "",
            "",
            "",
            "Гель 12 скорость",
            "Gel 12 speed",
            "",
            "",
            "",
            "",
            "",
            ""
        };

        /// <summary>
        /// 胶凝6速
        /// </summary>
        public string[] GelSpeed6 = {
            "",
            "",
            "胶凝6速",
            "",
            "",
            "",
            "Гель 6 скорость",
            "Gel 6 speed",
            "",
            "",
            "",
            "",
            "",
            ""
        };

        /// <summary>
        /// 胶凝5速
        /// </summary>
        public string[] GelSpeed5 = {
            "",
            "",
            "胶凝5速",
            "",
            "",
            "",
            "Гель 5 скорость",
            "Gel 5 speed",
            "",
            "",
            "",
            "",
            "",
            ""
        };

        /// <summary>
        /// 手动
        /// </summary>
        public string[] Manual = {
            "",
            "",
            "手动",
            "",
            "",
            "",
            "вручную",
            "Manual",
            "",
            "",
            "",
            "",
            "",
            ""
        };

        /// <summary>
        /// 倒计时
        /// </summary>
        public string[] CountDown = {
            "",
            "",
            "倒计时",
            "",
            "",
            "",
            "обратный отсчет",
            "Countdown",
            "",
            "",
            "",
            "",
            "",
            ""
        };

        #endregion

        #region [标签 * N] 表格头

        /// <summary>
        /// 递增读数
        /// </summary>
        public string[] IncRead = {
            "",
            "",
            "递增读数",
            "",
            "",
            "",
            "Добавочное чтение",
            "Incremental reading",
            "",
            "",
            "",
            "",
            "",
            ""
        };

        /// <summary>
        /// 递减读数
        /// </summary>
        public string[] DecrRead = {
            "",
            "",
            "递减读数",
            "",
            "",
            "",
            "Чтение декремента",
            "Decrement reading",
            "",
            "",
            "",
            "",
            "",
            ""
        };

        /// <summary>
        /// 读数比值
        /// </summary>
        public string[] RatRead = {
            "",
            "",
            "读数比值",
            "",
            "",
            "",
            "Коэффициент чтения",
            "Reading ratio",
            "",
            "",
            "",
            "",
            "",
            ""
        };

        /// <summary>
        /// 平均读数
        /// </summary>
        public string[] AveRead = {
            "",
            "",
            "平均读数",
            "",
            "",
            "",
            "Среднее чтение",
            "Average reading",
            "",
            "",
            "",
            "",
            "",
            ""
        };

        /// <summary>
        /// 100读数
        /// </summary>
        public string[] _100val = {
            "",
            "",
            "100读数",
            "",
            "",
            "",
            "100 чтений",
            "100 readings",
            "",
            "",
            "",
            "",
            "",
            ""
        };

        /// <summary>
        /// 200读数
        /// </summary>
        public string[] _200val = {
            "",
            "",
            "200读数",
            "",
            "",
            "",
            "200 чтений",
            "200 readings",
            "",
            "",
            "",
            "",
            "",
            ""
        };

        /// <summary>
        /// 300读数
        /// </summary>
        public string[] _300val = {
            "",
            "",
            "300读数",
            "",
            "",
            "",
            "300 чтений",
            "300 readings",
            "",
            "",
            "",
            "",
            "",
            ""
        };

        /// <summary>
        /// 比值法F
        /// </summary>
        public string[] RatMethodF = {
            "",
            "",
            "比值法F",
            "",
            "",
            "",
            "Соотношение метод F",
            "Ratio Method F",
            "",
            "",
            "",
            "",
            "",
            ""
        };

        /// <summary>
        /// 宾汉塑性模式
        /// </summary>
        public string[] BingHamPm = {
            "",
            "",
            "宾汉塑性模式",
            "",
            "",
            "",
            "Бингем пластиковый режим",
            "Bingham Plastic Mode",
            "",
            "",
            "",
            "",
            "",
            ""
        };

        /// <summary>
        /// 幂律模型
        /// </summary>
        public string[] PowerLawM = {
            "",
            "",
            "幂律模型",
            "",
            "",
            "",
            "Модель степенного закона",
            "Power Law Model",
            "",
            "",
            "",
            "",
            "",
            ""
        };

        /// <summary>
        /// 转速
        /// </summary>
        public string[] RotatingSpeed = {
            "",
            "",
            "转速（r/min）",
            "",
            "",
            "",
            "Скорость (об / мин)",
            "Speed (r/min)",
            "",
            "",
            "",
            "",
            "",
            ""
        };

        /// <summary>
        /// 仪器读数（F=1）
        /// </summary>
        public string[] InstRead = {
            "",
            "",
            "仪器读数（F=1）",
            "",
            "",
            "",
            "Чтение приборов (F = 1)",
            "Instrument reading (F=1)",
            "",
            "",
            "",
            "",
            "",
            ""
        };

        /// <summary>
        /// 剪切速率
        /// </summary>
        public string[] ShearRate = {
            "",
            "",
            "剪切速率（S^-1）",
            "",
            "",
            "",
            "Скорость сдвига (S ^ -1)",
            "Shear Rate (S^-1)",
            "",
            "",
            "",
            "",
            "",
            ""
        };

        /// <summary>
        /// 剪切应力（Pa）
        /// </summary>
        public string[] ShearStress = {
            "",
            "",
            "剪切应力（Pa）",
            "",
            "",
            "",
            "Напряжение сдвига (Па)",
            "Shear Stress (Pa)",
            "",
            "",
            "",
            "",
            "",
            ""
        };

        /// <summary>
        /// 相关系数
        /// </summary>
        public string[] CorreCoeff = {
            "",
            "",
            "相关系数",
            "",
            "",
            "",
            "Коэффициент корреляции",
            "Correlation Coefficient",
            "",
            "",
            "",
            "",
            "",
            ""
        };

        /// <summary>
        /// 一次胶凝值
        /// </summary>
        public string[] GelVal = {
            "",
            "",
            "一次胶凝值",
            "",
            "",
            "",
            "Значение гелеобразования",
            "Gelation value",
            "",
            "",
            "",
            "",
            "",
            ""
        };

        /// <summary>
        /// 二次胶凝值
        /// </summary>
        public string[] SecGelVal = {
            "",
            "",
            "二次胶凝值",
            "",
            "",
            "",
            "Вторичное значение гелеобразования",
            "Secondary gelation value",
            "",
            "",
            "",
            "",
            "",
            ""
        };

        /// <summary>
        /// 转速
        /// </summary>
        public string[] RotSpeed = {
            "",
            "",
            "转速",
            "",
            "",
            "",
            "скорость",
            "Rotating Speed",
            "",
            "",
            "",
            "",
            "",
            ""
        };

        /// <summary>
        /// 读数
        /// </summary>
        public string[] Reading = {
            "",
            "",
            "读数",
            "",
            "",
            "",
            "чтение",
            "Reading",
            "",
            "",
            "",
            "",
            "",
            ""
        };

        #endregion

        #region 
        #endregion


        #region 孵化器 2

        /// <summary>
        /// [标签]
        /// 关于
        /// </summary>
        public string[] 关于 = {
            "",
            "",
            "帮助",
            "",
            "",
            "",
            "помощь",
            "Help",
            "",
            "",
            "",
            "",
            "",
            ""
        };

        #endregion
    }
}
