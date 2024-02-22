// <auto-generated />
#nullable enable
#pragma warning disable CS1591

using System;
using System.Diagnostics;
using System.Drawing;
using CounterStrikeSharp;
using CounterStrikeSharp.API.Modules.Events;
using CounterStrikeSharp.API.Modules.Entities;
using CounterStrikeSharp.API.Modules.Memory;
using CounterStrikeSharp.API.Modules.Utils;
using CounterStrikeSharp.API.Core.Attributes;

namespace CounterStrikeSharp.API.Core;

public partial class CBaseGrenade : CBaseFlex
{
    public CBaseGrenade (IntPtr pointer) : base(pointer) {}

	// m_OnPlayerPickup
	[SchemaMember("CBaseGrenade", "m_OnPlayerPickup")]
	public CEntityIOOutput OnPlayerPickup => Schema.GetDeclaredClass<CEntityIOOutput>(this.Handle, "CBaseGrenade", "m_OnPlayerPickup");

	// m_OnExplode
	[SchemaMember("CBaseGrenade", "m_OnExplode")]
	public CEntityIOOutput OnExplode => Schema.GetDeclaredClass<CEntityIOOutput>(this.Handle, "CBaseGrenade", "m_OnExplode");

	// m_bHasWarnedAI
	[SchemaMember("CBaseGrenade", "m_bHasWarnedAI")]
	public ref bool HasWarnedAI => ref Schema.GetRef<bool>(this.Handle, "CBaseGrenade", "m_bHasWarnedAI");

	// m_bIsSmokeGrenade
	[SchemaMember("CBaseGrenade", "m_bIsSmokeGrenade")]
	public ref bool IsSmokeGrenade => ref Schema.GetRef<bool>(this.Handle, "CBaseGrenade", "m_bIsSmokeGrenade");

	// m_bIsLive
	[SchemaMember("CBaseGrenade", "m_bIsLive")]
	public ref bool IsLive => ref Schema.GetRef<bool>(this.Handle, "CBaseGrenade", "m_bIsLive");

	// m_DmgRadius
	[SchemaMember("CBaseGrenade", "m_DmgRadius")]
	public ref float DmgRadius => ref Schema.GetRef<float>(this.Handle, "CBaseGrenade", "m_DmgRadius");

	// m_flDetonateTime
	[SchemaMember("CBaseGrenade", "m_flDetonateTime")]
	public ref float DetonateTime => ref Schema.GetRef<float>(this.Handle, "CBaseGrenade", "m_flDetonateTime");

	// m_flWarnAITime
	[SchemaMember("CBaseGrenade", "m_flWarnAITime")]
	public ref float WarnAITime => ref Schema.GetRef<float>(this.Handle, "CBaseGrenade", "m_flWarnAITime");

	// m_flDamage
	[SchemaMember("CBaseGrenade", "m_flDamage")]
	public ref float Damage => ref Schema.GetRef<float>(this.Handle, "CBaseGrenade", "m_flDamage");

	// m_iszBounceSound
	[SchemaMember("CBaseGrenade", "m_iszBounceSound")]
	public string BounceSound
	{
		get { return Schema.GetUtf8String(this.Handle, "CBaseGrenade", "m_iszBounceSound"); }
		set { Schema.SetString(this.Handle, "CBaseGrenade", "m_iszBounceSound", value); }
	}

	// m_ExplosionSound
	[SchemaMember("CBaseGrenade", "m_ExplosionSound")]
	public string ExplosionSound
	{
		get { return Schema.GetUtf8String(this.Handle, "CBaseGrenade", "m_ExplosionSound"); }
		set { Schema.SetString(this.Handle, "CBaseGrenade", "m_ExplosionSound", value); }
	}

	// m_hThrower
	[SchemaMember("CBaseGrenade", "m_hThrower")]
	public CHandle<CCSPlayerPawn> Thrower => Schema.GetDeclaredClass<CHandle<CCSPlayerPawn>>(this.Handle, "CBaseGrenade", "m_hThrower");

	// m_flNextAttack
	[SchemaMember("CBaseGrenade", "m_flNextAttack")]
	public ref float NextAttack => ref Schema.GetRef<float>(this.Handle, "CBaseGrenade", "m_flNextAttack");

	// m_hOriginalThrower
	[SchemaMember("CBaseGrenade", "m_hOriginalThrower")]
	public CHandle<CCSPlayerPawn> OriginalThrower => Schema.GetDeclaredClass<CHandle<CCSPlayerPawn>>(this.Handle, "CBaseGrenade", "m_hOriginalThrower");

}