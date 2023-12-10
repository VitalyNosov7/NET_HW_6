﻿using System.Text.Json;

namespace Chat.Models
{
    public class MessageUdp
    {
        public int Id { get; set; }
        public string? FromName { get; set; }
        public string? ToName { get; set; }
        public string? Text { get; set; }
        public Command Command { get; set; }

        public string MessageToJson()
        {
            return JsonSerializer.Serialize(this);
        }
        public static MessageUdp MessageFromJson(string json)
        {
            return JsonSerializer.Deserialize<MessageUdp>(json) ?? new MessageUdp();
        }
    }
    public enum Command { Message, Register, Confirmation }
}