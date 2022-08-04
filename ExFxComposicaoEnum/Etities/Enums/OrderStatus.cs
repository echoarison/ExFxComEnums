
namespace ExFxComposicaoEnum.Etities.Enums
{
    //fazendo um enum para ficar mais pratico
    enum OrderStatus : int
    {
        //o proprio enum esta "auto atribuindo" os valores
        PendingPayment,
        Processing,
        Shipped,
        Delivered

    }
}
