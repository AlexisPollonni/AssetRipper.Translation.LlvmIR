using System;
using System.Runtime.CompilerServices;
using AssetRipper.Translation.LlvmIR.Runtime;
using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.InlineArrays;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalVariables;

[MangledName("_ZN19__llvm_libc_20_1_2_12_GLOBAL__N_16ATAN_IE")]
[DemangledName("__llvm_libc_20_1_2_::(anonymous namespace)::ATAN_I")]
internal static partial class Llvm_libc_20_1_2_anonymous_namespace_ATAN_I
{
	[FixedAddressValueType]
	private static InlineArray17_Llvm_libc_20_1_2_NumberPair __value;

	public unsafe static InlineArray17_Llvm_libc_20_1_2_NumberPair* Pointer => unchecked((InlineArray17_Llvm_libc_20_1_2_NumberPair*)Unsafe.AsPointer(ref __value));

	public static InlineArray17_Llvm_libc_20_1_2_NumberPair Value
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

	unsafe static Llvm_libc_20_1_2_anonymous_namespace_ATAN_I()
	{
		Value = new InlineArrayBuilder<InlineArray17_Llvm_libc_20_1_2_NumberPair, Llvm_libc_20_1_2_NumberPair>
		{
			default(Llvm_libc_20_1_2_NumberPair),
			new Llvm_libc_20_1_2_NumberPair
			{
				Lo = -1.5490756308295046E-18,
				Hi = 0.06241880999595735
			},
			new Llvm_libc_20_1_2_NumberPair
			{
				Lo = -3.1253241424539383E-18,
				Hi = 0.12435499454676144
			},
			new Llvm_libc_20_1_2_NumberPair
			{
				Lo = 4.180692268843079E-18,
				Hi = 0.18534794999569476
			},
			new Llvm_libc_20_1_2_NumberPair
			{
				Lo = 1.0698755618734451E-17,
				Hi = 0.24497866312686414
			},
			new Llvm_libc_20_1_2_NumberPair
			{
				Lo = -1.1010827903001369E-17,
				Hi = 0.3028848683749714
			},
			new Llvm_libc_20_1_2_NumberPair
			{
				Lo = -2.4623815582638635E-17,
				Hi = 0.35877067027057225
			},
			new Llvm_libc_20_1_2_NumberPair
			{
				Lo = -1.587652227770689E-17,
				Hi = 0.4124104415973873
			},
			new Llvm_libc_20_1_2_NumberPair
			{
				Lo = 2.2698777452961687E-17,
				Hi = 0.4636476090008061
			},
			new Llvm_libc_20_1_2_NumberPair
			{
				Lo = -2.5462781472855804E-17,
				Hi = 0.5123894603107377
			},
			new Llvm_libc_20_1_2_NumberPair
			{
				Lo = -5.4556305485916264E-18,
				Hi = 0.5585993153435624
			},
			new Llvm_libc_20_1_2_NumberPair
			{
				Lo = 2.950430737228402E-17,
				Hi = 0.6022873461349642
			},
			new Llvm_libc_20_1_2_NumberPair
			{
				Lo = 1.5834785051444286E-17,
				Hi = 0.6435011087932844
			},
			new Llvm_libc_20_1_2_NumberPair
			{
				Lo = 6.943223671560008E-18,
				Hi = 0.6823165548747481
			},
			new Llvm_libc_20_1_2_NumberPair
			{
				Lo = -2.1478388444456983E-17,
				Hi = 0.7188299996216245
			},
			new Llvm_libc_20_1_2_NumberPair
			{
				Lo = -2.4256934659182068E-17,
				Hi = 0.7531512809621944
			},
			new Llvm_libc_20_1_2_NumberPair
			{
				Lo = 3.061616997868383E-17,
				Hi = Math.PI / 4.0
			}
		};
		PointerIndices.Register(Pointer);
	}
}
