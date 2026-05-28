using System.Runtime.CompilerServices;
using AssetRipper.Translation.LlvmIR.Runtime;
using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.InlineArrays;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalVariables;

[MangledName("__const._ZN19__llvm_libc_20_1_2_12_GLOBAL__N_114poly_approx_ddERKNS_10NumberPairIdEE.COEFFS.49")]
[DemangledName("__const._ZN19__llvm_libc_20_1_2_12_GLOBAL__N_114poly_approx_ddERKNS_10NumberPairIdEE.COEFFS.49")]
internal static partial class _49
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

	unsafe static _49()
	{
		Value = new InlineArrayBuilder<InlineArray7_NumberPair, NumberPair>
		{
			new NumberPair
			{
				Lo = 0.0,
				Hi = 1.0
			},
			new NumberPair
			{
				Lo = -2.1707562233811494E-16,
				Hi = 2.302585092994046
			},
			new NumberPair
			{
				Lo = -2.0935887830547685E-16,
				Hi = 2.650949055239199
			},
			new NumberPair
			{
				Lo = 1.669593387016762E-16,
				Hi = 2.034678592293476
			},
			new NumberPair
			{
				Lo = 6.66917755934106E-17,
				Hi = 1.171255148912267
			},
			new NumberPair
			{
				Lo = 2.5419896662003015E-17,
				Hi = 0.5393829295760609
			},
			new NumberPair
			{
				Lo = -1.0602582695538038E-17,
				Hi = 0.20699584869686802
			}
		};
		_ = Pointer;
	}
}
