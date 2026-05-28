using AssetRipper.Translation.LlvmIR.Runtime;
using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.InlineArrays;

namespace LlvmLibC.GlobalVariables;

[MangledName("_ZN19__llvm_libc_20_1_2_11K_LOG2_EVENE")]
[DemangledName("__llvm_libc_20_1_2_::K_LOG2_EVEN")]
internal static partial class K_LOG2_EVEN
{
	private static InlineArray4_Double __value;

	public static InlineArray4_Double Value
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

	static K_LOG2_EVEN()
	{
		Value = InlineArrayHelper.Create<InlineArray4_Double, double>(new double[4] { -0.7213475204444817, -0.36067376022224085, -0.2404491734814939, -0.14426950408889633 });
	}
}
