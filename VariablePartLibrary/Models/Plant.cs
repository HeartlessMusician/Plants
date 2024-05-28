﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using VariablePartLibrary.Services;

namespace VariablePartLibrary.Models
{
    public class Plant : IModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public BitmapImage Image { get => new BitmapImage(new Uri(Path.GetFullPath(Path.Combine(Directory.GetCurrentDirectory(), $@"../../../VariablePartLibrary/Resources/{Id}.jpg")))); }
        public string Countries { get; set; }
        public int PlantTypeId { get; set; }

        public Plant()
        {

        }

        public Plant(int id, string name, int plantTypeId, string description, string countries)
        {
            Id = id;
            Name = name;
            PlantTypeId = plantTypeId;
            Countries = countries;
            Description = description;
        }

        public PlantType PlantType
        {
            get
            {
                return DBService.Instance.GetModelData<PlantType>().FirstOrDefault(x => x.Id == PlantTypeId);
            }
        }

        public List<IModel> GenerateData()
        {
            List<IModel> data = new List<IModel>();

            data.Add(new Plant(1, "Ива", 1, " род древесных растений семейства Ивовые. В русском языке по отношению к видам ивы используется также много других названий — ветла́, раки́та, лоза́, лози́на, ве́рба, тальник. Очень распространённые в средней части России растения.", "Россия"));
            data.Add(new Plant(2, "Дуб", 1, "род деревьев и кустарников семейства Буковые, объединяющий более 600 видов. Дуб хорошо узнаваем благодаря его плодам — желудям.","Россия"));
            data.Add(new Plant(3, "Пальма", 1, "Представлено большей частью древесными растениями с неразветвлёнными (кроме дум-пальмы) стволами, в которых происходит первичное утолщение (то есть утолщение за счёт деятельности протодермы и основной меристемы). Имеется также некоторое число видов, для которых характерны тонкие ползучие или лазающие побеги (например, представители рода Calamus). В семейство входят 185 родов и около 3400 видов.", "Колумбия, Мадагаскар"));
            data.Add(new Plant(4, "Оливка", 1, "Оли́ва европе́йская, или Масли́на культу́рная, или Масли́на европе́йская, или Оли́вковое де́рево — вечнозелёное субтропическое дерево; вид рода Маслина семейства Маслиновые. Растение с древности возделывается для получения оливкового масла, в диком виде не встречается.", "Турция, Греция, Италия"));
            data.Add(new Plant(5, "Адансония", 1, "Род назван в честь французского ботаника и путешественника Мишеля Адансона, подробно описавшего баобаб (Adansonia digitata). Иногда название «баобаб» употребляется по отношению ко всем видам адансоний. Иногда баобаб называют «обезьяньим хлебным деревом», так как мякоть его плодов чрезвычайно привлекает обезьян. За форму ствола баобаб называют «бутылочным деревом». Из мякоти плодов готовят напиток, по вкусу напоминающий лимонад, отсюда ещё одно название баобаба — «лимонадное дерево».","Африка"));
            data.Add(new Plant(6, "Лавр", 1, "субтропическое дерево или кустарник, вид рода Лавр семейства Лавровые. Его листья используют как пряность. От названия этого растения произошли имена Лавр, Лаврентий, Лаура, Лоренц, слово «лауреат», выражения «лавровый венок », «почивать на лаврах», «пожинать лавры»", "Индия, Непал"));
            data.Add(new Plant(7, "Тополь", 1, "род двудомных листопадных быстрорастущих деревьев семейства Ивовые. Лес с преобладанием тополей называют тополёвником.", "Мексика, Китай, Россия"));
            data.Add(new Plant(8, "Фикус", 1, " род растений семейства Тутовые, в составе которого образует монотипную трибу Фикусовые. Большинство видов — вечнозелёные, некоторые — листопадные.", "Россия, Италия"));

            data.Add(new Plant(9, "Шиповник", 2, "род растений семейства Розовые порядка Розоцветные. По этому роду были названы и семейство, и порядок, к которым он относится. Имеет множество культурных форм, разводимых под названием Роза. Розой в ботанической литературе часто называют и сам шиповник.", "Россия, Казахстан, Китай"));
            data.Add(new Plant(10, "Форзиция", 2, "Форзи́ция, также форса́йтия, или форси́ция — род кустарников и небольших деревьев семейства Маслиновые. ", "Франция, Германия"));
            data.Add(new Plant(11, "Магнолия", 2, " род цветковых растений семейства Магнолиевые, содержащий около 240 видов.", "Россия, Китай, США"));
            data.Add(new Plant(12, "Пион", 2, "род травянистых многолетников и листопадных кустарников. Единственный род семейства Пионовые, ранее род относили к семейству Лютиковых. Пионы цветут в конце весны, ценятся садоводами за пышную листву, эффектные цветы и декоративные плоды.", "Россия, США, Казахстан"));
            data.Add(new Plant(13, "Барбарис", 2, "крупный род кустарников, реже деревьев, семейства Барбарисовые", "Россия"));
            data.Add(new Plant(14, "Клен", 2, "род древесных растений семейства Сапиндовые, ранее помещался в семейство Клёновые, ныне рассматриваемое в ранге трибы Клёновые в составе подсемейства Конскокаштановые. Клён широко распространён в Европе, Азии и Северной Америке.", "Страны Азии, США, Россия"));
            data.Add(new Plant(15, "Жасмин", 2, "род вечнозелёных кустарников из семейства Маслиновые. Не следует путать его с кустарником чубушник, который в России часто неправильно называют жасмином. Представители рода встречаются в тёплом поясе обоих полушарий, включая субтропики.", "Турция, Индия, Италия"));

            data.Add(new Plant(16, "Вороний глаз четырехлистный", 3, "Воро́ний глаз четырёхли́стный, или Вороний глаз обыкнове́нный, или Парижская трава или Парижская ягода — вид травянистых растений из рода Вороний глаз семейства Мелантиевые. Смертельно ядовитое растение.", "Африка"));
            data.Add(new Plant(17, "Гравилат речной", 3, "Гравила́т речно́й, Гравилат ручейный, или Гравилат прируче́йный — вид многолетних растений рода Гравилат семейства Розовые, встречается в Евразии и Северной Америке.", "Америка, страны Евразии"));
            data.Add(new Plant(18, "Грушанка круглолистная", 3, " вид многолетних цветковых растений рода Грушанка семейства Вересковые, ранее этот род относили к семейству Грушанковые.", "Африка, Евразия, Европа"));
            data.Add(new Plant(19, "Дудник лесной", 3, "Ду́дник лесно́й, или Дягиль лесной — вид растений рода Дудник семейства Зонтичные.", "Китай, Европа"));
            data.Add(new Plant(20, "Живучка ползучая", 3, "Живу́чка ползу́чая — многолетнее травянистое растение, вид рода Живучка семейства Яснотковые. Наиболее часто культивируемый вид рода. Медонос. Удовлетворительно поедается скотом. Используется в народной медицине. Устаревшие русские названия растения — горловинка, горлянка.", "Россия, США"));
            data.Add(new Plant(21, "Звездчатка жёстколистная", 3, "известная как большая звездчатка , большая звездчатка и гадюка , представляет собой многолетнее травянистое цветущее растение семейства Caryophyllaceae . Ранее он относился к роду Stellaria как Stellaria holostea, но в 2019 году был переведен в род Rabelera на основании филогенетического анализа.", "Кавказ, Индия"));
            data.Add(new Plant(22, "Зеленчук жёлтый", 3, "Ясно́тка зеленчуко́вая, или Ясно́тка жёлтая — многолетнее травянистое растение, вид рода Яснотка семейства Яснотковые.", "Италия, Испания"));
            data.Add(new Plant(23, "Кипрей болотный", 3, "многолетнее травянистое растение, вид рода Кипрей семейства Кипрейные. Образует тонкие нитевидные стелющиеся столоны. Листья узкие, часто линейно-ланцетные, цельнокрайные. Встречается по болотистым местам.", "Россия, Казахстан"));
            data.Add(new Plant(24, "Кислица обыкновенная", 3, "Кисли́ца обыкнове́нная — многолетнее травянистое растение, вид рода Кислица семейства Кисличные. Народные названия — «заячья капуста» и «кукушкин клевер».", "Америка, Евразия"));

            return data;
        }
    }
}
