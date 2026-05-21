using System.Runtime.CompilerServices;
using AssetRipper.Translation.LlvmIR.Runtime;
using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.InlineArrays;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalVariables;

[MangledName("_ZN19__llvm_libc_20_1_2_12_GLOBAL__N_16COEFFSE.61")]
[DemangledName("__llvm_libc_20_1_2_::(anonymous namespace)::COEFFS (.61)")]
internal static partial class Llvm_libc_20_1_2_anonymous_namespace_COEFFS_61
{
	[FixedAddressValueType]
	private static InlineArray9_Llvm_libc_20_1_2_NumberPair __value;

	public unsafe static InlineArray9_Llvm_libc_20_1_2_NumberPair* Pointer => unchecked((InlineArray9_Llvm_libc_20_1_2_NumberPair*)Unsafe.AsPointer(ref __value));

	public static InlineArray9_Llvm_libc_20_1_2_NumberPair Value
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

	unsafe static Llvm_libc_20_1_2_anonymous_namespace_COEFFS_61()
	{
		Value = new InlineArrayBuilder<InlineArray9_Llvm_libc_20_1_2_NumberPair, Llvm_libc_20_1_2_NumberPair>
		{
			new Llvm_libc_20_1_2_NumberPair
			{
				Lo = 0.0,
				Hi = 1.0
			},
			new Llvm_libc_20_1_2_NumberPair
			{
				Lo = -1.850371707708594E-17,
				Hi = -1.0 / 3.0
			},
			new Llvm_libc_20_1_2_NumberPair
			{
				Lo = -1.1102230246251566E-17,
				Hi = 0.2
			},
			new Llvm_libc_20_1_2_NumberPair
			{
				Lo = -7.93016446160826E-18,
				Hi = -1.0 / 7.0
			},
			new Llvm_libc_20_1_2_NumberPair
			{
				Lo = 6.1679056923619804E-18,
				Hi = 1.0 / 9.0
			},
			new Llvm_libc_20_1_2_NumberPair
			{
				Lo = 2.523234146875356E-18,
				Hi = -1.0 / 11.0
			},
			new Llvm_libc_20_1_2_NumberPair
			{
				Lo = -4.270088556250602E-18,
				Hi = 1.0 / 13.0
			},
			new Llvm_libc_20_1_2_NumberPair
			{
				Lo = -9.251858538542971E-19,
				Hi = -1.0 / 15.0
			},
			new Llvm_libc_20_1_2_NumberPair
			{
				Lo = 8.163404592832033E-19,
				Hi = 1.0 / 17.0
			}
		};
		PointerIndices.Register(Pointer);
	}
}
