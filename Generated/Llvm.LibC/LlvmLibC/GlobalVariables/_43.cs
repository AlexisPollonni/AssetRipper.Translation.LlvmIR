using System.Runtime.CompilerServices;
using AssetRipper.Translation.LlvmIR.Runtime;
using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.InlineArrays;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalVariables;

[MangledName("__const._ZN19__llvm_libc_20_1_2_12_GLOBAL__N_114poly_approx_ddERKNS_10NumberPairIdEE.COEFFS.43")]
[DemangledName("__const._ZN19__llvm_libc_20_1_2_12_GLOBAL__N_114poly_approx_ddERKNS_10NumberPairIdEE.COEFFS.43")]
internal static partial class _43
{
	[FixedAddressValueType]
	private static InlineArray7_Llvm_libc_20_1_2_NumberPair __value;

	public unsafe static InlineArray7_Llvm_libc_20_1_2_NumberPair* Pointer => unchecked((InlineArray7_Llvm_libc_20_1_2_NumberPair*)Unsafe.AsPointer(ref __value));

	public static InlineArray7_Llvm_libc_20_1_2_NumberPair Value
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
		Value = new InlineArrayBuilder<InlineArray7_Llvm_libc_20_1_2_NumberPair, Llvm_libc_20_1_2_NumberPair>
		{
			new Llvm_libc_20_1_2_NumberPair
			{
				Lo = 0.0,
				Hi = 1.0
			},
			new Llvm_libc_20_1_2_NumberPair
			{
				Lo = 2.3190468138464576E-17,
				Hi = 0.6931471805599453
			},
			new Llvm_libc_20_1_2_NumberPair
			{
				Lo = -9.493931253184786E-18,
				Hi = 0.24022650695910072
			},
			new Llvm_libc_20_1_2_NumberPair
			{
				Lo = -3.1677282390002793E-18,
				Hi = 0.05550410866482158
			},
			new Llvm_libc_20_1_2_NumberPair
			{
				Lo = 2.836306484358366E-19,
				Hi = 0.009618129107628477
			},
			new Llvm_libc_20_1_2_NumberPair
			{
				Lo = -9.597927132481008E-20,
				Hi = 0.001333355814983819
			},
			new Llvm_libc_20_1_2_NumberPair
			{
				Lo = 1.5636080759655632E-21,
				Hi = 0.00015403530393384403
			}
		};
		PointerIndices.Register(Pointer);
	}
}
