using System.Runtime.CompilerServices;
using AssetRipper.Translation.LlvmIR.Runtime;
using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.InlineArrays;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalVariables;

[MangledName("__const._ZN19__llvm_libc_20_1_2_12_GLOBAL__N_114poly_approx_ddERKNS_10NumberPairIdEE.COEFFS.55")]
[DemangledName("__const._ZN19__llvm_libc_20_1_2_12_GLOBAL__N_114poly_approx_ddERKNS_10NumberPairIdEE.COEFFS.55")]
internal static partial class _55
{
	[FixedAddressValueType]
	private static InlineArray7_NumberPair __value;

	public unsafe static InlineArray7_NumberPair* Pointer => unchecked((InlineArray7_NumberPair*)Unsafe.AsPointer(ref __value));

	public static InlineArray7_NumberPair Value
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

	unsafe static _55()
	{
		Value = new InlineArrayBuilder<InlineArray7_NumberPair, NumberPair>
		{
			new NumberPair
			{
				lo = 0.0,
				hi = 1.0
			},
			new NumberPair
			{
				lo = 0.0,
				hi = 1.0
			},
			new NumberPair
			{
				lo = 0.0,
				hi = 0.5
			},
			new NumberPair
			{
				lo = 9.25185853854297E-18,
				hi = 1.0 / 6.0
			},
			new NumberPair
			{
				lo = 2.3129646346357427E-18,
				hi = 1.0 / 24.0
			},
			new NumberPair
			{
				lo = 1.1564823173178714E-19,
				hi = 1.0 / 120.0
			},
			new NumberPair
			{
				lo = -5.300543954373577E-20,
				hi = 1.0 / 720.0
			}
		};
		PointerIndices.Register(Pointer);
	}
}
