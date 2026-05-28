using System;
using System.Runtime.CompilerServices;
using AssetRipper.Translation.LlvmIR.Runtime;
using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.InlineArrays;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalVariables;

[MangledName("_ZN19__llvm_libc_20_1_2_12_GLOBAL__N_16ATAN_IE")]
[DemangledName("__llvm_libc_20_1_2_::(anonymous namespace)::ATAN_I")]
internal static partial class Anonymous_namespace_ATAN_I
{
	[FixedAddressValueType]
	private static InlineArray17_NumberPair __value;

	public unsafe static InlineArray17_NumberPair* Pointer => unchecked((InlineArray17_NumberPair*)Unsafe.AsPointer(ref __value));

	public static InlineArray17_NumberPair Value
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

	unsafe static Anonymous_namespace_ATAN_I()
	{
		Value = new InlineArrayBuilder<InlineArray17_NumberPair, NumberPair>
		{
			default(NumberPair),
			new NumberPair
			{
				Lo = -1.5490756308295046E-18,
				Hi = 0.06241880999595735
			},
			new NumberPair
			{
				Lo = -3.1253241424539383E-18,
				Hi = 0.12435499454676144
			},
			new NumberPair
			{
				Lo = 4.180692268843079E-18,
				Hi = 0.18534794999569476
			},
			new NumberPair
			{
				Lo = 1.0698755618734451E-17,
				Hi = 0.24497866312686414
			},
			new NumberPair
			{
				Lo = -1.1010827903001369E-17,
				Hi = 0.3028848683749714
			},
			new NumberPair
			{
				Lo = -2.4623815582638635E-17,
				Hi = 0.35877067027057225
			},
			new NumberPair
			{
				Lo = -1.587652227770689E-17,
				Hi = 0.4124104415973873
			},
			new NumberPair
			{
				Lo = 2.2698777452961687E-17,
				Hi = 0.4636476090008061
			},
			new NumberPair
			{
				Lo = -2.5462781472855804E-17,
				Hi = 0.5123894603107377
			},
			new NumberPair
			{
				Lo = -5.4556305485916264E-18,
				Hi = 0.5585993153435624
			},
			new NumberPair
			{
				Lo = 2.950430737228402E-17,
				Hi = 0.6022873461349642
			},
			new NumberPair
			{
				Lo = 1.5834785051444286E-17,
				Hi = 0.6435011087932844
			},
			new NumberPair
			{
				Lo = 6.943223671560008E-18,
				Hi = 0.6823165548747481
			},
			new NumberPair
			{
				Lo = -2.1478388444456983E-17,
				Hi = 0.7188299996216245
			},
			new NumberPair
			{
				Lo = -2.4256934659182068E-17,
				Hi = 0.7531512809621944
			},
			new NumberPair
			{
				Lo = 3.061616997868383E-17,
				Hi = Math.PI / 4.0
			}
		};
		_ = Pointer;
	}
}
