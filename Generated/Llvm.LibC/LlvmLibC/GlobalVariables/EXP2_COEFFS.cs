using System.Runtime.CompilerServices;
using AssetRipper.Translation.LlvmIR.Runtime;
using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.InlineArrays;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalVariables;

[MangledName("__const._ZN19__llvm_libc_20_1_2_12_GLOBAL__N_118powf_double_doubleEidddRKNS_10NumberPairIdEE.EXP2_COEFFS")]
[DemangledName("__const._ZN19__llvm_libc_20_1_2_12_GLOBAL__N_118powf_double_doubleEidddRKNS_10NumberPairIdEE.EXP2_COEFFS")]
internal static partial class EXP2_COEFFS
{
	[FixedAddressValueType]
	private static InlineArray10_Llvm_libc_20_1_2_NumberPair __value;

	public unsafe static InlineArray10_Llvm_libc_20_1_2_NumberPair* Pointer => unchecked((InlineArray10_Llvm_libc_20_1_2_NumberPair*)Unsafe.AsPointer(ref __value));

	public static InlineArray10_Llvm_libc_20_1_2_NumberPair Value
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
		Value = new InlineArrayBuilder<InlineArray10_Llvm_libc_20_1_2_NumberPair, Llvm_libc_20_1_2_NumberPair>
		{
			new Llvm_libc_20_1_2_NumberPair
			{
				Lo = 0.0,
				Hi = 1.0
			},
			new Llvm_libc_20_1_2_NumberPair
			{
				Lo = 3.62351064663483E-19,
				Hi = 0.010830424696249145
			},
			new Llvm_libc_20_1_2_NumberPair
			{
				Lo = -2.317854311570888E-21,
				Hi = 5.86490495505617E-05
			},
			new Llvm_libc_20_1_2_NumberPair
			{
				Lo = -1.2076653566812759E-23,
				Hi = 2.1173137155464776E-07
			},
			new Llvm_libc_20_1_2_NumberPair
			{
				Lo = 1.69485141086382E-26,
				Hi = 5.732851688640402E-10
			},
			new Llvm_libc_20_1_2_NumberPair
			{
				Lo = 1.2037694632896793E-29,
				Hi = 1.2417843701716925E-12
			},
			new Llvm_libc_20_1_2_NumberPair
			{
				Lo = -1.5802929922543314E-31,
				Hi = 2.2415086850198263E-15
			},
			new Llvm_libc_20_1_2_NumberPair
			{
				Lo = -1.1497119428560973E-34,
				Hi = 3.4680701455908595E-18
			},
			new Llvm_libc_20_1_2_NumberPair
			{
				Lo = -1.9663541776363824E-37,
				Hi = 4.695087808618542E-21
			},
			new Llvm_libc_20_1_2_NumberPair
			{
				Lo = -2.787460577828603E-40,
				Hi = 5.6499669485797814E-24
			}
		};
		PointerIndices.Register(Pointer);
	}
}
