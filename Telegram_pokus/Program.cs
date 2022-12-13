using System;
using Telegram.Bot;
using Telegram.Bot.Polling;
using Telegram.Bot.Types;
using Telegram.Bot.Types.Enums;

namespace Telegram_pokus
{
    internal class Program
    {
        static TelegramBotClient Bot = new TelegramBotClient("5604187671:AAEAFhuLb0c9VZ6dm__bzp8kBpaF_CR5iHc");
        

        static void Main(string[] args)
        {
            var receiverOptions = new ReceiverOptions
            {
                AllowedUpdates = new UpdateType[]
                {
                    UpdateType.Message,
                    UpdateType.EditedMessage,
                }
            };

            var chatID = new ChatId(5755763311);

            Bot.SendTextMessageAsync(chatID,"hi");

            Bot.StartReceiving(UpdateHandler, ErrorHandler, receiverOptions);

            Console.ReadLine();
        }
        private static Task ErrorHandler(ITelegramBotClient arg1, Exception arg2, CancellationToken arg3)
        {
            throw new NotImplementedException();
        }

        private static async Task UpdateHandler(ITelegramBotClient bot, Update update, CancellationToken arg3)
        {
            if (update.Message.Type == MessageType.Text)
            {
                var text = update.Message.Text;
                var id = update.Message.Chat.Id;
                string? username = update.Message.Chat.Username;
                Console.WriteLine($"{text} | {id} | {username}");
            }
        }

    }
}


