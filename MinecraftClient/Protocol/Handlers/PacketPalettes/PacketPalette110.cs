﻿using System.Collections.Generic;

namespace MinecraftClient.Protocol.Handlers.PacketPalettes
{
    public class PacketPalette110 : PacketTypePalette
    {
        private readonly Dictionary<int, PacketTypesIn> typeIn = new()
        {
            { 0x00, PacketTypesIn.SpawnEntity },
            { 0x01, PacketTypesIn.SpawnExperienceOrb },
            { 0x02, PacketTypesIn.SpawnWeatherEntity },
            { 0x03, PacketTypesIn.SpawnLivingEntity },
            { 0x04, PacketTypesIn.SpawnPainting },
            { 0x05, PacketTypesIn.SpawnPlayer },
            { 0x06, PacketTypesIn.EntityAnimation },
            { 0x07, PacketTypesIn.Statistics },
            { 0x08, PacketTypesIn.BlockBreakAnimation },
            { 0x09, PacketTypesIn.BlockEntityData },
            { 0x0A, PacketTypesIn.BlockAction },
            { 0x0B, PacketTypesIn.BlockChange },
            { 0x0C, PacketTypesIn.BossBar },
            { 0x0D, PacketTypesIn.ServerDifficulty },
            { 0x0E, PacketTypesIn.TabComplete },
            { 0x0F, PacketTypesIn.ChatMessage },
            { 0x10, PacketTypesIn.MultiBlockChange },
            { 0x11, PacketTypesIn.WindowConfirmation },
            { 0x12, PacketTypesIn.CloseWindow },
            { 0x13, PacketTypesIn.OpenWindow },
            { 0x14, PacketTypesIn.WindowItems },
            { 0x15, PacketTypesIn.WindowProperty },
            { 0x16, PacketTypesIn.SetSlot },
            { 0x17, PacketTypesIn.SetCooldown },
            { 0x18, PacketTypesIn.PluginMessage },
            { 0x19, PacketTypesIn.NamedSoundEffect },
            { 0x1A, PacketTypesIn.Disconnect },
            { 0x1B, PacketTypesIn.EntityStatus },
            { 0x1C, PacketTypesIn.Explosion },
            { 0x1D, PacketTypesIn.UnloadChunk },
            { 0x1E, PacketTypesIn.ChangeGameState },
            { 0x1F, PacketTypesIn.KeepAlive },
            { 0x20, PacketTypesIn.ChunkData },
            { 0x21, PacketTypesIn.Effect },
            { 0x22, PacketTypesIn.Particle },
            { 0x23, PacketTypesIn.JoinGame },
            { 0x24, PacketTypesIn.MapData },
            { 0x25, PacketTypesIn.EntityPosition },
            { 0x26, PacketTypesIn.EntityPositionAndRotation },
            { 0x27, PacketTypesIn.EntityRotation },
            { 0x28, PacketTypesIn.EntityMovement },
            { 0x29, PacketTypesIn.VehicleMove },
            { 0x2A, PacketTypesIn.OpenSignEditor },
            { 0x2B, PacketTypesIn.PlayerAbilities },
            { 0x2C, PacketTypesIn.CombatEvent },
            { 0x2D, PacketTypesIn.PlayerInfo },
            { 0x2E, PacketTypesIn.PlayerPositionAndLook },
            { 0x2F, PacketTypesIn.UseBed },
            { 0x30, PacketTypesIn.DestroyEntities },
            { 0x31, PacketTypesIn.RemoveEntityEffect },
            { 0x32, PacketTypesIn.ResourcePackSend },
            { 0x33, PacketTypesIn.Respawn },
            { 0x34, PacketTypesIn.EntityHeadLook },
            { 0x35, PacketTypesIn.WorldBorder },
            { 0x36, PacketTypesIn.Camera },
            { 0x37, PacketTypesIn.HeldItemChange },
            { 0x38, PacketTypesIn.DisplayScoreboard },
            { 0x39, PacketTypesIn.EntityMetadata },
            { 0x3A, PacketTypesIn.AttachEntity },
            { 0x3B, PacketTypesIn.EntityVelocity },
            { 0x3C, PacketTypesIn.EntityEquipment },
            { 0x3D, PacketTypesIn.SetExperience },
            { 0x3E, PacketTypesIn.UpdateHealth },
            { 0x3F, PacketTypesIn.ScoreboardObjective },
            { 0x40, PacketTypesIn.SetPassengers },
            { 0x41, PacketTypesIn.Teams },
            { 0x42, PacketTypesIn.UpdateScore },
            { 0x43, PacketTypesIn.SpawnPosition },
            { 0x44, PacketTypesIn.TimeUpdate },
            { 0x45, PacketTypesIn.Title },
            { 0x46, PacketTypesIn.SoundEffect },
            { 0x47, PacketTypesIn.PlayerListHeaderAndFooter },
            { 0x48, PacketTypesIn.CollectItem },
            { 0x49, PacketTypesIn.EntityTeleport },
            { 0x4A, PacketTypesIn.EntityProperties },
            { 0x4B, PacketTypesIn.EntityEffect },
        };

        private readonly Dictionary<int, PacketTypesOut> typeOut = new()
        {
            { 0x00, PacketTypesOut.TeleportConfirm },
            { 0x01, PacketTypesOut.TabComplete },
            { 0x02, PacketTypesOut.ChatMessage },
            { 0x03, PacketTypesOut.ClientStatus },
            { 0x04, PacketTypesOut.ClientSettings },
            { 0x05, PacketTypesOut.WindowConfirmation },
            { 0x06, PacketTypesOut.EnchantItem },
            { 0x07, PacketTypesOut.ClickWindow },
            { 0x08, PacketTypesOut.CloseWindow },
            { 0x09, PacketTypesOut.PluginMessage },
            { 0x0A, PacketTypesOut.InteractEntity },
            { 0x0B, PacketTypesOut.KeepAlive },
            { 0x0C, PacketTypesOut.PlayerPosition },
            { 0x0D, PacketTypesOut.PlayerPositionAndRotation },
            { 0x0E, PacketTypesOut.PlayerRotation },
            { 0x0F, PacketTypesOut.PlayerMovement },
            { 0x10, PacketTypesOut.VehicleMove },
            { 0x11, PacketTypesOut.SteerBoat },
            { 0x12, PacketTypesOut.PlayerAbilities },
            { 0x13, PacketTypesOut.PlayerDigging },
            { 0x14, PacketTypesOut.EntityAction },
            { 0x15, PacketTypesOut.SteerVehicle },
            { 0x16, PacketTypesOut.ResourcePackStatus },
            { 0x17, PacketTypesOut.HeldItemChange },
            { 0x18, PacketTypesOut.CreativeInventoryAction },
            { 0x19, PacketTypesOut.UpdateSign },
            { 0x1A, PacketTypesOut.Animation },
            { 0x1B, PacketTypesOut.Spectate },
            { 0x1C, PacketTypesOut.PlayerBlockPlacement },
            { 0x1D, PacketTypesOut.UseItem },
        };

        protected override Dictionary<int, PacketTypesIn> GetListIn() => typeIn;
        protected override Dictionary<int, PacketTypesOut> GetListOut() => typeOut;
        protected override Dictionary<int, ConfigurationPacketTypesIn> GetConfigurationListIn() => null!;
        protected override Dictionary<int, ConfigurationPacketTypesOut> GetConfigurationListOut() => null!;
    }
}
