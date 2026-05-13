using System.Runtime.CompilerServices;
using AssetRipper.Translation.LlvmIR.Runtime;
using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.InlineArrays;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalVariables;

[MangledName("__const._ZN19__llvm_libc_20_1_2_12_GLOBAL__N_118powf_double_doubleEidddRKNS_10NumberPairIdEE.COEFFS")]
[DemangledName("__const._ZN19__llvm_libc_20_1_2_12_GLOBAL__N_118powf_double_doubleEidddRKNS_10NumberPairIdEE.COEFFS")]
[CleanName("COEFFS")]
internal static partial class COEFFS_yazmcg
{
	[FixedAddressValueType]
	private static InlineArray6_NumberPair __value;

	public unsafe static InlineArray6_NumberPair* Pointer => unchecked((InlineArray6_NumberPair*)Unsafe.AsPointer(ref __value));

	public static InlineArray6_NumberPair Value
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

	unsafe static COEFFS_yazmcg()
	{
		Value = new InlineArrayBuilder<InlineArray6_NumberPair, NumberPair>
		{
			new NumberPair
			{
				lo = 2.0355273740950545E-17,
				hi = 1.4426950408889634
			},
			new NumberPair
			{
				lo = -1.0177636921052553E-17,
				hi = -0.7213475204444817
			},
			new NumberPair
			{
				lo = 2.5046067001847476E-17,
				hi = 0.4808983469629878
			},
			new NumberPair
			{
				lo = 1.4933885608475666E-17,
				hi = -0.3606737602222407
			},
			new NumberPair
			{
				lo = -5.9310858384503784E-18,
				hi = 0.28853900862513104
			},
			new NumberPair
			{
				lo = 8.16367584820295E-18,
				hi = -0.24044930263082626
			}
		};
		PointerIndices.Register(Pointer);
	}
}
