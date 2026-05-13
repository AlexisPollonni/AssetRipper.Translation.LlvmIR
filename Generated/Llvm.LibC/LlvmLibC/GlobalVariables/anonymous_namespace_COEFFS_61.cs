using System.Runtime.CompilerServices;
using AssetRipper.Translation.LlvmIR.Runtime;
using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.InlineArrays;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalVariables;

[MangledName("_ZN19__llvm_libc_20_1_2_12_GLOBAL__N_16COEFFSE.61")]
[DemangledName("__llvm_libc_20_1_2_::(anonymous namespace)::COEFFS (.61)")]
internal static partial class anonymous_namespace_COEFFS_61
{
	[FixedAddressValueType]
	private static InlineArray9_NumberPair __value;

	public unsafe static InlineArray9_NumberPair* Pointer => unchecked((InlineArray9_NumberPair*)Unsafe.AsPointer(ref __value));

	public static InlineArray9_NumberPair Value
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

	unsafe static anonymous_namespace_COEFFS_61()
	{
		Value = new InlineArrayBuilder<InlineArray9_NumberPair, NumberPair>
		{
			new NumberPair
			{
				lo = 0.0,
				hi = 1.0
			},
			new NumberPair
			{
				lo = -1.850371707708594E-17,
				hi = -1.0 / 3.0
			},
			new NumberPair
			{
				lo = -1.1102230246251566E-17,
				hi = 0.2
			},
			new NumberPair
			{
				lo = -7.93016446160826E-18,
				hi = -1.0 / 7.0
			},
			new NumberPair
			{
				lo = 6.1679056923619804E-18,
				hi = 1.0 / 9.0
			},
			new NumberPair
			{
				lo = 2.523234146875356E-18,
				hi = -1.0 / 11.0
			},
			new NumberPair
			{
				lo = -4.270088556250602E-18,
				hi = 1.0 / 13.0
			},
			new NumberPair
			{
				lo = -9.251858538542971E-19,
				hi = -1.0 / 15.0
			},
			new NumberPair
			{
				lo = 8.163404592832033E-19,
				hi = 1.0 / 17.0
			}
		};
		PointerIndices.Register(Pointer);
	}
}
