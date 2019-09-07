namespace HantelShop.Models {

    /// <summary>Отзыв пользователя</summary>
    public class Rating : AbstractBase {

        /// <summary>Создаёт новый экземпляр класса <see cref="Rating"/></summary>
        /// <param name="name">Имя</param>
        protected Rating(string name) : base(name) { }
        /// <summary>Создаёт новый экземпляр класса <see cref="Rating"/></summary>
        /// <param name="subject">Объект оценки</param>
        /// <param name="user">Пользователь</param>
        public Rating(AbstractBase subject, ApplicationUser user) {
            Subject = subject;
            User = user;
            Name = subject.Name;
        }

        /// <summary>Объект оценки</summary>
        public AbstractBase Subject { get; set; }
        /// <summary>Пользователь</summary>
        public ApplicationUser User { get; set; }
        /// <summary>Баллы</summary>
        public RatingEnum Points { get; set; }
        /// <summary>Достоинства</summary>
        public string Goodies { get; set; }
        /// <summary>Недостатки</summary>
        public string Minuses { get; set; }

    }

    /// <summary>Оценка в баллах</summary>
    public enum RatingEnum {
        /// <summary>Отвратительно</summary>
        Disgusting,
        /// <summary>Плохо</summary>
        Poorly,
        /// <summary>Посредственно</summary>
        Mediocre,
        /// <summary>Хорошо</summary>
        Good,
        /// <summary>Отлично</summary>
        Fine
    }

}