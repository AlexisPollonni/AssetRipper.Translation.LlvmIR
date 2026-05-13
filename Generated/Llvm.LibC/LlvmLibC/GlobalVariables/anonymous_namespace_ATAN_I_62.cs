using System;
using System.Runtime.CompilerServices;
using AssetRipper.Translation.LlvmIR.Runtime;
using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.InlineArrays;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalVariables;

[MangledName("_ZN19__llvm_libc_20_1_2_12_GLOBAL__N_16ATAN_IE.62")]
[DemangledName("__llvm_libc_20_1_2_::(anonymous namespace)::ATAN_I (.62)")]
internal static partial class anonymous_namespace_ATAN_I_62
{
	[FixedAddressValueType]
	private static InlineArray65_NumberPair __value;

	public unsafe static InlineArray65_NumberPair* Pointer => unchecked((InlineArray65_NumberPair*)Unsafe.AsPointer(ref __value));

	public static InlineArray65_NumberPair Value
	{
		get
		{
			return __value;
		}
		set
		{
			__value = value;
		}
	}

	unsafe static anonymous_namespace_ATAN_I_62()
	{
		Value = new InlineArrayBuilder<InlineArray65_NumberPair, NumberPair>
		{
			default(NumberPair),
			new NumberPair
			{
				lo = -4.913600136566304E-19,
				hi = 0.015623728620476831
			},
			new NumberPair
			{
				lo = -1.188442711587748E-18,
				hi = 0.031239833430268277
			},
			new NumberPair
			{
				lo = -1.655677442254952E-19,
				hi = 0.046840712915969654
			},
			new NumberPair
			{
				lo = -1.5490756308295046E-18,
				hi = 0.06241880999595735
			},
			new NumberPair
			{
				lo = 5.804551873143357E-18,
				hi = 0.0779666338315423
			},
			new NumberPair
			{
				lo = -6.2844725995420954E-18,
				hi = 0.09347678115858947
			},
			new NumberPair
			{
				lo = 6.8267122072409585E-18,
				hi = 0.10894195698986579
			},
			new NumberPair
			{
				lo = -3.1253241424539383E-18,
				hi = 0.12435499454676144
			},
			new NumberPair
			{
				lo = -2.9579864247315813E-18,
				hi = 0.13970887428916365
			},
			new NumberPair
			{
				lo = 9.585415594114324E-18,
				hi = 0.15499674192394097
			},
			new NumberPair
			{
				lo = -3.541164079802125E-18,
				hi = 0.1702119252854744
			},
			new NumberPair
			{
				lo = 4.180692268843079E-18,
				hi = 0.18534794999569476
			},
			new NumberPair
			{
				lo = 3.1399542871844493E-18,
				hi = 0.2003985538258785
			},
			new NumberPair
			{
				lo = 4.738160130078733E-19,
				hi = 0.21535769969773805
			},
			new NumberPair
			{
				lo = 1.2313404529142703E-17,
				hi = 0.23021958727684372
			},
			new NumberPair
			{
				lo = 1.0698755618734451E-17,
				hi = 0.24497866312686414
			},
			new NumberPair
			{
				lo = 1.9238754924615304E-17,
				hi = 0.2596296294082575
			},
			new NumberPair
			{
				lo = 8.261353575163773E-18,
				hi = 0.2741674511196588
			},
			new NumberPair
			{
				lo = -1.428369957377257E-17,
				hi = 0.2885873618940774
			},
			new NumberPair
			{
				lo = -1.1010827903001369E-17,
				hi = 0.3028848683749714
			},
			new NumberPair
			{
				lo = -1.893928924292642E-17,
				hi = 0.31705575320914703
			},
			new NumberPair
			{
				lo = -7.952610375793799E-18,
				hi = 0.3310960767041321
			},
			new NumberPair
			{
				lo = -2.2938804755578304E-17,
				hi = 0.34500217720710513
			},
			new NumberPair
			{
				lo = -2.4623815582638635E-17,
				hi = 0.35877067027057225
			},
			new NumberPair
			{
				lo = 1.9612311504845653E-17,
				hi = 0.3723984466767542
			},
			new NumberPair
			{
				lo = 2.378822732491941E-17,
				hi = 0.38588266939807375
			},
			new NumberPair
			{
				lo = 2.246598105617042E-17,
				hi = 0.39922076957525254
			},
			new NumberPair
			{
				lo = -1.587652227770689E-17,
				hi = 0.4124104415973873
			},
			new NumberPair
			{
				lo = 2.3315530741892885E-17,
				hi = 0.42544963737004227
			},
			new NumberPair
			{
				lo = -2.494277030626541E-17,
				hi = 0.43833655985795783
			},
			new NumberPair
			{
				lo = -2.2703795229420475E-17,
				hi = 0.4510696559885235
			},
			new NumberPair
			{
				lo = 2.2698777452961687E-17,
				hi = 0.4636476090008061
			},
			new NumberPair
			{
				lo = 1.4654487332256713E-17,
				hi = 0.4760693303227612
			},
			new NumberPair
			{
				lo = -1.1373236189329585E-17,
				hi = 0.48833395105640554
			},
			new NumberPair
			{
				lo = -4.7181675085518756E-17,
				hi = 0.5004408131472942
			},
			new NumberPair
			{
				lo = -2.5462781472855804E-17,
				hi = 0.5123894603107377
			},
			new NumberPair
			{
				lo = 5.520094119641666E-18,
				hi = 0.5241796287829132
			},
			new NumberPair
			{
				lo = -4.0637956834825575E-18,
				hi = 0.5358112379604637
			},
			new NumberPair
			{
				lo = 4.923709671396255E-17,
				hi = 0.5472843809874369
			},
			new NumberPair
			{
				lo = -5.4556305485916264E-18,
				hi = 0.5585993153435624
			},
			new NumberPair
			{
				lo = 1.2255062085054184E-17,
				hi = 0.5697564534829784
			},
			new NumberPair
			{
				lo = -1.441464378193067E-17,
				hi = 0.5807563535676704
			},
			new NumberPair
			{
				lo = 4.920495453686772E-17,
				hi = 0.5915997103351114
			},
			new NumberPair
			{
				lo = 2.950430737228402E-17,
				hi = 0.6022873461349642
			},
			new NumberPair
			{
				lo = -3.1552061848586226E-17,
				hi = 0.6128202021652414
			},
			new NumberPair
			{
				lo = 2.672403885140095E-17,
				hi = 0.6231993299340659
			},
			new NumberPair
			{
				lo = -2.7290767436015276E-17,
				hi = 0.6334258829691446
			},
			new NumberPair
			{
				lo = 1.5834785051444286E-17,
				hi = 0.6435011087932844
			},
			new NumberPair
			{
				lo = 3.5800634857340095E-17,
				hi = 0.6534263411807619
			},
			new NumberPair
			{
				lo = -3.076054864429649E-17,
				hi = 0.6632029927060933
			},
			new NumberPair
			{
				lo = -1.899315009714705E-17,
				hi = 0.6728325475937632
			},
			new NumberPair
			{
				lo = 6.943223671560008E-18,
				hi = 0.6823165548747481
			},
			new NumberPair
			{
				lo = -8.117151192285796E-18,
				hi = 0.6916566218531999
			},
			new NumberPair
			{
				lo = -1.987626234335816E-17,
				hi = 0.7008544078844502
			},
			new NumberPair
			{
				lo = -4.597166450584887E-17,
				hi = 0.7099116184635249
			},
			new NumberPair
			{
				lo = -2.1478388444456983E-17,
				hi = 0.7188299996216245
			},
			new NumberPair
			{
				lo = 2.569325697391839E-18,
				hi = 0.7276113326265107
			},
			new NumberPair
			{
				lo = 3.473937648299457E-17,
				hi = 0.7362574289814281
			},
			new NumberPair
			{
				lo = 3.708315849135547E-17,
				hi = 0.7447701257160751
			},
			new NumberPair
			{
				lo = -2.4256934659182068E-17,
				hi = 0.7531512809621944
			},
			new NumberPair
			{
				lo = 9.850030332752822E-18,
				hi = 0.7614027698055784
			},
			new NumberPair
			{
				lo = -3.704991905602721E-17,
				hi = 0.7695264804056583
			},
			new NumberPair
			{
				lo = -2.6676490951944502E-17,
				hi = 0.7775243103733478
			},
			new NumberPair
			{
				lo = 3.061616997868383E-17,
				hi = Math.PI / 4.0
			}
		};
		PointerIndices.Register(Pointer);
	}
}
