using System.Runtime.CompilerServices;
using LlvmLibC.Helpers;
using LlvmLibC.InlineArrays;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalVariables;

[MangledName("__const._ZN19__llvm_libc_20_1_2_12_GLOBAL__N_114poly_approx_ddERKNS_10NumberPairIdEE.COEFFS.43")]
[DemangledName("__const._ZN19__llvm_libc_20_1_2_12_GLOBAL__N_114poly_approx_ddERKNS_10NumberPairIdEE.COEFFS.43")]
internal static partial class _43
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

	unsafe static _43()
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
				lo = 2.3190468138464576E-17,
				hi = 0.6931471805599453
			},
			new NumberPair
			{
				lo = -9.493931253184786E-18,
				hi = 0.24022650695910072
			},
			new NumberPair
			{
				lo = -3.1677282390002793E-18,
				hi = 0.05550410866482158
			},
			new NumberPair
			{
				lo = 2.836306484358366E-19,
				hi = 0.009618129107628477
			},
			new NumberPair
			{
				lo = -9.597927132481008E-20,
				hi = 0.001333355814983819
			},
			new NumberPair
			{
				lo = 1.5636080759655632E-21,
				hi = 0.00015403530393384403
			}
		};
		PointerIndices.Register(Pointer);
	}
}
