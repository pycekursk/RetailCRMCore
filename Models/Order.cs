using Newtonsoft.Json;

namespace RetailCRMCore.Models
{
    public class Order
    {
        /// <summary>
        /// ID заказа
        /// </summary>
        public int id { get; set; }
        /// <summary>
        /// Внешний ID заказа
        /// </summary>
        public string externalId { get; set; }
        /// <summary>
        /// Номер заказа
        /// </summary>
        public string number { get; set; }
        /// <summary>
        /// Дата оформления заказа
        /// </summary>
        public DateTime createdAt { get; set; }
        /// <summary>
        /// Тип заказа
        /// </summary>
        public string orderType { get; set; }
        /// <summary>
        /// Способ оформления
        /// </summary>
        public string orderMethod { get; set; }
        /// <summary>
        /// Тип привилегии
        /// </summary>
        public string privilegeType { get; set; }
        /// <summary>
        /// ISO код страны (ISO 3166-1 alpha-2)
        /// </summary>
        public string country { get; set; }
        /// <summary>
        /// Магазин
        /// </summary>
        public string site { get; set; }
        /// <summary>
        /// Статус заказа
        /// </summary>
        public string status { get; set; }
        /// <summary>
        /// Комментарий к последнему изменению статуса
        /// </summary>
        public string statusComment { get; set; }
        /// <summary>
        /// Дата последнего изменения статуса
        /// </summary>
        public string statusUpdatedAt { get; set; }
        /// <summary>
        /// Менеджер заказа
        /// </summary>
        public User? manager { get; set; }

        public int managerId { get; set; }
        /// <summary>
        /// Фамилия
        /// </summary>
        public string lastName { get; set; }
        /// <summary>
        /// Имя
        /// </summary>
        public string firstName { get; set; }
        /// <summary>
        /// Отчество
        /// </summary>
        public string patronymic { get; set; }
        /// <summary>
        /// ФИО
        /// </summary>
        public string nickName { get; set; }
        /// <summary>
        /// Телефон
        /// </summary>
        public string phone { get; set; }
        /// <summary>
        /// Дополнительный телефон
        /// </summary>
        public string additionalPhone { get; set; }
        /// <summary>
        /// Любой найденый телефон
        /// </summary>
        public string anyPhone { get; set; }
        /// <summary>
        /// E-mail
        /// </summary>
        public string email { get; set; }
        /// <summary>
        /// Любой найденый e-mail
        /// </summary>
        public string anyEmail { get; set; }
        /// <summary>
        /// Клиент
        /// </summary>
        public Customer customer { get; set; }
        /// <summary>
        /// Контактное лицо
        /// </summary>
        public Contact contact { get; set; }
        /// <summary>
        /// Компания
        /// </summary>
        public Company company { get; set; }
        /// <summary>
        /// Реквизиты
        /// </summary>
        public Contragent contragent { get; set; }
        /// <summary>
        /// Товары в заказе (в том числе и отмененные)
        /// </summary>
        //public OrderProduct[] orderProducts { get; set; }
        /// <summary>
        /// Товары в заказе (рекомендуется использовать данный метод для получения товаров)
        /// </summary>
        public string availableOrderProducts { get; set; }
        /// <summary>
        /// Общее количество товаров в заказе. Если вызвать с параметром getQuantity(false), то также учитываются отмененные товары
        /// </summary>
        public string quantity { get; set; }
        /// <summary>
        /// Сумма по товарам. Если вызвать с параметром getSumm(false), то в сумму также включается стоимость отмененных товаров
        /// </summary>
        public double summ { get; set; }
        /// <summary>
        /// Общая стоимость закупки
        /// </summary>
        public double purchaseSumm { get; set; }
        /// <summary>
        /// Суммарная скидка на товары
        /// </summary>
        public double discountSumm { get; set; }
        /// <summary>
        /// Количество начисленных бонусов
        /// </summary>
        public double bonusesCreditTotal { get; set; }
        /// <summary>
        /// Количество списанных бонусов
        /// </summary>
        public double bonusesChargeTotal { get; set; }
        /// <summary>
        /// Тип доставки
        /// </summary>
        //public DeliveryType deliveryType { get; set; } = new DeliveryType();
        /// <summary>
        /// Служба доставки
        /// </summary>
        //public DeliveryService deliveryService { get; set; } = new DeliveryService();
        /// <summary>
        /// Адрес доставки
        /// </summary>
        //public Address deliveryAddress { get; set; } = new Address();
        /// <summary>
        /// Дата доставки
        /// </summary>
        //public DateTime deliveryDate { get; set; }
        /// <summary>
        /// Время доставки
        /// </summary>
        //public string deliveryTime { get; set; }
        /// <summary>
        /// deprecated Время доставки "с"
        /// </summary>
        //public string deliveryTimeFrom { get; set; }
        /// <summary>
        /// deprecated Время доставки "до"
        /// </summary>
        //public string deliveryTimeTo { get; set; }
        /// <summary>
        /// deprecated Время доставки в свободной форме
        /// </summary>
        //public string deliveryTimeCustom { get; set; }
        /// <summary>
        /// deprecated Строковое представление времени доставки
        /// </summary>
        //public string deliveryTimeString { get; set; }
        /// <summary>
        /// Стоимость доставки
        /// </summary>
        //public string deliveryCost { get; set; }
        /// <summary>
        /// Себестоимость доставки
        /// </summary>
        //public string deliveryNetCost { get; set; }
        /// <summary>
        /// Стоимость доставки задается вручную
        /// </summary>
        //public string deliveryCostIsManual { get; set; }
        /// <summary>
        /// Себестоимость доставки задается вручную
        /// </summary>
        //public string deliveryNetCostIsManual { get; set; }
        /// <summary>
        /// deprecated Номер отправления в интеграционной службе доставки. Используйте getIntegrationDeliveryData().trackNumber
        /// </summary>
        public string integrationDeliveryTrackId { get; set; }
        /// <summary>
        /// deprecated Номер отправления Почтой России либо EMS (если заказ доставляется соответствующим способом). Используйте getIntegrationDeliveryData().trackNumber
        /// </summary>
        public string russianPostTrackNumber { get; set; }
        /// <summary>
        /// deprecated Статус доставки отправления Почтой России либо EMS. Используйте getIntegrationDeliveryData().status
        /// </summary>
        public string russianPostDeliveryStatus { get; set; }
        /// <summary>
        /// deprecated Номер отправления СДЭК (если заказ доставляется соответствующим способом). Используйте getIntegrationDeliveryData().trackNumber
        /// </summary>
        public string sdekExternalId { get; set; }
        /// <summary>
        /// Курьер, назначенный на заказ (если заказ доставляется соответствующим способом)
        /// </summary>
        public string courier { get; set; }
        /// <summary>
        /// deprecated Тариф доставки для DPD. Используйте getIntegrationDeliveryData().deliveryName
        /// </summary>
        public string dpdDeliveryName { get; set; }
        /// <summary>
        /// deprecated Доставка до терминала для DPD. Используйте getIntegrationDeliveryData().toPickuppoint
        /// </summary>
        public string isDpdPickupPoint { get; set; }
        /// <summary>
        /// deprecated Номер отправления для DPD. Используйте getIntegrationDeliveryData().trackNumber
        /// </summary>
        public string dpdExternalId { get; set; }
        /// <summary>
        /// Денежная скидка на весь заказ
        /// </summary>
        public string discountManualAmount { get; set; }
        /// <summary>
        /// Процентная скидка на весь заказ. Система округляет это значение до 2 знаков после запятой
        /// </summary>
        public string discountManualPercent { get; set; }
        /// <summary>
        /// Персональная скидка на заказ
        /// </summary>
        public string personalDiscountPercent { get; set; }
        /// <summary>
        /// Денежная скидка на весь заказ
        /// </summary>
        public string discount { get; set; }
        /// <summary>
        /// Процентная скидка на весь заказ
        /// </summary>
        public string discountPercent { get; set; }
        /// <summary>
        /// Итоговая скидка на заказ
        /// </summary>
        public string totalDiscount { get; set; }
        /// <summary>
        /// Участие в программе лояльности
        /// </summary>
        public object loyaltyAccount { get; set; }
        /// <summary>
        /// Уровень участия в программе лояльности
        /// </summary>
        public object loyaltyLevel { get; set; }
        /// <summary>
        /// Скидка по событию программы лояльности
        /// </summary>
        public object loyaltyEventDiscount { get; set; }
        /// <summary>
        /// Ставка НДС доставки
        /// </summary>
        //public string deliveryVatRate { get; set; }
        /// <summary>
        /// Общая сумма с учетом скидки
        /// </summary>
        public double totalSumm { get; set; }
        /// <summary>
        /// Оплаченная сумма
        /// </summary>
        public double prepaySum { get; set; }
        /// <summary>
        /// Сумма, оставшаяся к оплате
        /// </summary>
        public double toPaySumm { get; set; }
        /// <summary>
        /// Оценка заказа
        /// </summary>
        public int mark { get; set; }
        /// <summary>
        /// Дата и время получение оценки от покупателя
        /// </summary>
        public string markDatetime { get; set; }
        /// <summary>
        /// Просрочен
        /// </summary>
        public bool expired { get; set; }
        /// <summary>
        /// Требуется позвонить
        /// </summary>
        public bool call { get; set; }
        /// <summary>
        /// Комментарий клиента
        /// </summary>
        public string customerComment { get; set; }
        /// <summary>
        /// Комментарий оператора
        /// </summary>
        public string managerComment { get; set; }
        /// <summary>
        /// Валовая прибыль заказа
        /// </summary>
        public double marginSumm { get; set; }
        /// <summary>
        /// Заказ поступил через API
        /// </summary>
        public bool fromApi { get; set; }
        /// <summary>
        /// Дата полной оплаты
        /// </summary>
        public string fullPaidAt { get; set; }
        /// <summary>
        /// Платежи
        /// </summary>

        //TODO : не сериализуется сука...
        public dynamic payments { get; set; }

        /// <summary>
        /// Данные интеграционной доставки
        /// </summary>
        public object integrationDeliveryData { get; set; }
        /// <summary>
        /// Источник заказа
        /// </summary>
        public Source source { get; set; }
        /// <summary>
        /// Склад отгрузки
        /// </summary>
        public string shipmentStore { get; set; }
        /// <summary>
        /// Дата отгрузки
        /// </summary>
        public string shipmentDate { get; set; }
        /// <summary>
        /// Заказ отгружен
        /// </summary>
        public bool shipped { get; set; }
        /// <summary>
        /// Заказ можно отгрузить
        /// </summary>
        public string isShipmentAllowed { get; set; }
        /// <summary>
        /// Вес. При getMax = true возвращает наибольший из обычного и объемного веса
        /// </summary>
        public double weight { get; set; }
        /// <summary>
        /// Длина
        /// </summary>
        public int length { get; set; }
        /// <summary>
        /// Ширина
        /// </summary>
        public int width { get; set; }
        /// <summary>
        /// Высота
        /// </summary>
        public int height { get; set; }
        /// <summary>
        /// Сумма по товарам без учета скидок на товары
        /// </summary>
        public string initialProductSumm { get; set; }
        /// <summary>
        /// deprecated Статус оплаты
        /// </summary>
        //public string paymentStatus { get; set; }
        /// <summary>
        /// deprecated Тип оплаты
        /// </summary>
        //public PaymentType paymentType { get; set; }
        /// <summary>
        /// deprecated Детали платежа
        /// </summary>
        //public string paymentDetail { get; set; }
        /// <summary>
        /// MessageGateway диалог
        /// </summary>
        public object dialog { get; set; }
        /// <summary>
        /// Время до следующего заказа, в секундах
        /// </summary>
        public string secondsToNextOrder { get; set; }
        /// <summary>
        /// Ассоциативный массив пользовательских полей
        /// </summary>
        public string[] customFields { get; set; }
        /// <summary>
        /// Возвращает значение пользовательского поля. В code указывается символьный код поля.
        /// </summary>
        public string customField { get; set; }
        /// <summary>
        /// Метка клиента Google Analytics
        /// </summary>
        public object clientId { get; set; }
        /// <summary>
        /// Метка клиента Google Analytics (строка)
        /// </summary>
        public string clientIdString { get; set; }
        /// <summary>
        /// Прикрепленные объекты (вложения)
        /// </summary>
        public object attachments { get; set; }
        /// <summary>
        /// Список затрат
        /// </summary>
        public object costs { get; set; }

        public Delivery delivery { get; set; }

        public OrderProduct[] items { get; set; }
        public RetailCRMCore.V2.Models.Address deliveryAddress { get; set; }
    }
}