using System.Runtime.CompilerServices;
using LlvmLibC.Helpers;
using LlvmLibC.InlineArrays;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalVariables;

[MangledName("__const._ZN19__llvm_libc_20_1_2_12_GLOBAL__N_118powf_double_doubleEidddRKNS_10NumberPairIdEE.EXP2_COEFFS")]
[DemangledName("__const._ZN19__llvm_libc_20_1_2_12_GLOBAL__N_118powf_double_doubleEidddRKNS_10NumberPairIdEE.EXP2_COEFFS")]
internal static partial class EXP2_COEFFS
{
	[FixedAddressValueType]
	private static InlineArray10_NumberPair __value;

	public unsafe static InlineArray10_NumberPair* Pointer => unchecked((InlineArray10_NumberPair*)Unsafe.AsPointer(ref __value));

	public static InlineArray10_NumberPair Value
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

	unsafe static EXP2_COEFFS()
	{
		Value = new InlineArrayBuilder<InlineArray10_NumberPair, NumberPair>
		{
			new NumberPair
			{
				lo = 0.0,
				hi = 1.0
			},
			new NumberPair
			{
				lo = 3.62351064663483E-19,
				hi = 0.010830424696249145
			},
			new NumberPair
			{
				lo = -2.317854311570888E-21,
				hi = 5.86490495505617E-05
			},
			new NumberPair
			{
				lo = -1.2076653566812759E-23,
				hi = 2.1173137155464776E-07
			},
			new NumberPair
			{
				lo = 1.69485141086382E-26,
				hi = 5.732851688640402E-10
			},
			new NumberPair
			{
				lo = 1.2037694632896793E-29,
				hi = 1.2417843701716925E-12
			},
			new NumberPair
			{
				lo = -1.5802929922543314E-31,
				hi = 2.2415086850198263E-15
			},
			new NumberPair
			{
				lo = -1.1497119428560973E-34,
				hi = 3.4680701455908595E-18
			},
			new NumberPair
			{
				lo = -1.9663541776363824E-37,
				hi = 4.695087808618542E-21
			},
			new NumberPair
			{
				lo = -2.787460577828603E-40,
				hi = 5.6499669485797814E-24
			}
		};
		PointerIndices.Register(Pointer);
	}
}
