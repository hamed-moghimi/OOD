using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using OOD.EMS.Execution;
using OOD.EMS.Users;
using OOD.EMS.Management;
using OOD.EMS.Audit;

namespace OOD
{
    class StaticData
    {
        public static void initialize()
        {
            // create a user
            User u = UserStorage.getInstance().all()[0];

            // initialize a department
            Department d = new Department("اداره کل امور موقتی", null, u);
            OrganizationStructure.getInstance().create(d);

            // general goal
            GeneralGoal g = new GeneralGoal("رتبه‌ی اول در جهان", "بشیم دیگه!");
            GeneralGoalStorage.getInstance().create(g);

            // executive goal
            ExecutiveGoal e = new ExecutiveGoal("تجهیز بنادر کشور", "در سطح یک بینل", d);
            ExecutionProgram p = new ExecutionProgram("تجهیز بنادر کشور", "در سطح یک بینل");
            e.program = p;
            ExecutiveGoalStorage.getInstance().create(e);

            // initialize tasks
            Task t1 = new Task("خرید کشتی موقتی", DateTime.Today, DateTime.Today + TimeSpan.FromDays(10), 0, d, "");
            TaskStorage.getInstance().create(t1);
            Task t2 = new Task("برگزاری همایش ایمنی در بنادر", DateTime.Today - TimeSpan.FromDays(30), DateTime.Today + TimeSpan.FromDays(3), 35, d, "");
            TaskStorage.getInstance().create(t2);

            // assign tasks
            p.addTask(t1, 55);
            p.addTask(t2, 45);

            // audit tasks
            var a = new TaskAudit(t2, u, "همه‌چی خیلی خیلی خوب داره پیش می‌ره!", 55, null);
            TaskAuditStorage.getInstance().create(a);

            var r = new Random();

            // metrics
            Metric m = new Metric("حجم گاز دی‌اکسید کربن", "متر مکعب");
            MetricStorage.getInstance().create(m);
            var values = new double[] { 100.2, 120.0, 208.5, 100.2, 120.0, 208.5 };
            foreach (double v in values)
            {
                var val = new MetricValue(m, v, DateTime.Now);
                val.Date = DateTime.Today + TimeSpan.FromDays(r.Next(20));
                MetricValueStorage.getInstance().create(val);
            }

            m = new Metric("حجم گاز منواکسید کربن", "متر مکعب");
            MetricStorage.getInstance().create(m);
            values = new double[] { 10.2, 45.0, 20.5 };
            foreach (double v in values)
            {
                var val = new MetricValue(m, v, DateTime.Now);
                val.Date = DateTime.Today + TimeSpan.FromDays(r.Next(7));
                MetricValueStorage.getInstance().create(val);
            }

            // metrics
            m = new Metric("حجم گاز تری‌اکسید کربن", "متر مکعب");
            MetricStorage.getInstance().create(m);
            values = new double[] { 70.2, 52.0, 98.5, 70.2, 60.0, 38.5 };
            foreach (double v in values)
            {
                var val = new MetricValue(m, v, DateTime.Now);
                val.Date = DateTime.Today + TimeSpan.FromDays(r.Next(20));
                MetricValueStorage.getInstance().create(val);
            }
        }

        #region old_static_codes
        // resource: title, amount, description
        public static List<object[]> resources = new List<object[]>();
        private static object[][] _resources = new object[][] {
            new object[] {"نفت‌کش C1423", "۳ فروند", "واقع در بندر امام خمینی، خرمشهر و شهید رجایی"},
            new object[] {"حساب ارزی سازمان بنادر", "۵۵۴ میلیون دلار", "بر اساس نظر مدیرعامل و با اجازه وزیر اجازه برداشت از حساب ارزی وجود دارد"},
            new object[] {"کشتی لایروبی", "۱۳ فروند", "۱۰ فروند در بنادر خلیج فارس و ۳ فروند در بنادر دریای خزر"},
        };

        // training resource: title, field, description, attachments, text
        public static List<object[]> trainings = new List<object[]>();
        private static object[][] _trainings = new object[][] {
            new object[] {"تاثیرات نفت بر موجودات دریایی", "تاثیرات زیست‌محیطی", "در این مستند، تاثیرات لکه‌های نفتی بر زندگی موجودات دریایی به تصویر درآمده است.", "۱ فایل"},
            new object[] {"کاهش آلودگی‌های گرمایی", "تاثیرات زیست‌محیطی", "آلودگی گرمایی چیست؟ چگونه می‌توان در کارخانجات، واحدهای صنعتی و اداری و حتی واحدهای مسکونی از آن جلوگیری کرد؟", "ندارد"}
        };

        // executive goal: title, start date, responsible
        public static List<object[]> executiveGoals = new List<object[]>();
        private static object[][] _executiveGoals = new object[][] {
            new object[] {"کاهش ۲۵ درصدی شاخص آلاینده‌های نفتی در بندر خرمشهر", "۲۶ / ۲ / ۱۳۹۳","اداره کل بندر خرمشهر"},
            new object[] {"تهیه ۳ فروند کشتی لای‌روبی در خلیج فارس", "۲۶ / ۲ / ۱۳۹۳","اداره کل تجهیزات"},
        };

        // schedule: goal, start date, end date, progress
        public static List<object[]> schedules = new List<object[]>();
        private static object[][] _schedules = new object[][] {
            new object[] {"کاهش ۲۵ درصدی شاخص آلاینده‌های نفتی در بندر خرمشهر", "۲۶ / ۲ / ۱۳۹۳", "۲۶ / ۲ / ۱۳۹۴", "۲۳٪"},
            new object[] {"تهیه ۳ فروند کشتی لای‌روبی در خلیج فارس", "۲۶ / ۲ / ۱۳۹۳", "۲۶ / ۲ / ۱۳۹۵", "۵٪"},
        };

        // tasks: title, start date, end date, progress
        public static List<object[]> tasks = new List<object[]>();
        private static object[][] _tasks = new object[][] {
            new object[] {5, "برگزاری مناقصه داخلی و خارجی", "روابط عمومی و امور بین‌الملل", "۲۶ / ۲ / ۱۳۹۳", "۲۶ / ۴ / ۱۳۹۳", "۲۳٪"},
            new object[] {15, "طراحی و کنترل فنی طرح اولیه پیمانکار کشتی‌ساز", "اداره کل تجهیزات" ,"۲۶ / ۵ / ۱۳۹۳", "۲۶ / ۱۰ / ۱۳۹۳", "۵٪"},
        };

        // general goal: title, description, attachment
        public static List<object[]> generalGoals = new List<object[]>();
        private static object[][] _generalGoals = new object[][] {
            new object[] {"کاهش آلاینده‌های زیست‌محیطی کشتی‌ها تا حد استاندارد اروپا", "باید شاخص آلایندگی کشتی‌های نفت‌کش که عمده آلودگی‌های زیست‌محیطی خلیج فارس ناشی از آن‌هاست تا حد قابل‌قبولی کاهش یابد", "file.pdf"},
            new object[] {"‫افزایش ایمنی در بنادر و کاهش احتمال آتش‌سوزی فراورده‌های نفتی", "امکانات ایمنی در بنادر به گونه‌ای فراهم شود تا علاوه بر پیش‌گیری از وقوع آتش‌سوزی در بندر و وارد آمدن خسارات مالی و جانی، میزان آلاینده‌های ناشی از حریق مواد نفتی نیز کاهش داشته باشد", "file.pdf"},
            new object[] {"‫کاهش میزان آلودگی اسکله و بخش ترانزیت بنادر", "نشت مواد سمی و وارد‌شدن آلودگی‌های شیمیایی و میکروبی به آب‌های اسکله‌های ترانزیت باید کاهش داشته باشد", "file.pdf"},
        };

        public static List<object[]> Metrics = new List<object[]>();
        private static object[][] _Metrics = new object[][] {
            new object[] {"حجم آلاینده‌های نفتی آزاد شده در آب"},
            new object[] {"حجم گاز دی‌اکسیدکربن"},
            new object[] {"هزینه‌ی سالیانه"},
            new object[] {"تلفات آبزیان"},
        };

        public static List<object[]> LegalReq = new List<object[]>();
        private static object[][] _LegalReq = new object[][] {
            new object[] {"تضمین ضریب ایمنی پرسنل بندر مطابق با مصوبه وزارت کار و رفاه اجتماعی ", "توضیح"},
            new object[] {"خارج کردن نفت‌کش های با عمر بالاتر از ۳۰ سال تا پایان سال ۹۵ مطابق با مصوبه وزارت نفت ", "توضیح"},

        };

        public static List<object[]> effects = new List<object[]>();
        private static object[][] _effects = new object[][] {
            new object[] {"سند بررسی تاثیر جمعیت پرسنل بندری بر میانگین شاخص آلاینده‌های زیست‌محیطی در بنادر خلیج فارس ", "توضیح"},
            
        };

        public static List<object[]> relations = new List<object[]>();
        private static object[][] _relations = new object[][] {
            new object[] {"خارج کردن نفت‌کش های فرسوده تا پایان سال ۹۵  ", "کاهش آلاینده‌های زیست‌محیطی کشتی‌ها "},
            new object[] {"خارج کردن نفت‌کش های فرسوده تا پایان سال ۹۵  ", "کاهش میزان آلودگی اسکله و بخش ترانزیت بنادر"},
        };

        public static List<object[]> users = new List<object[]>();
        private static object[][] _users = new object[][] {
            new object[] {"مینا طهماسبی", "کاربر میانی"},
            new object[] {"حامد مقیمی", "کاربر ارشد"},
            new object[] {"علی طبسی", "بازرس"},
            new object[] {"زینب نویدی", "مدبر سامانه"},
        };
        #endregion
    }
}
