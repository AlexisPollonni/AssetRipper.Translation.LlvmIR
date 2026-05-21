using AssetRipper.Translation.LlvmIR.Runtime;
using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.InlineArrays;

namespace LlvmLibC.GlobalVariables;

[MangledName("_ZN19__llvm_libc_20_1_2_10K_LOG2_ODDE")]
[DemangledName("__llvm_libc_20_1_2_::K_LOG2_ODD")]
internal static partial class Llvm_libc_20_1_2_K_LOG2_ODD
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

	static Llvm_libc_20_1_2_K_LOG2_ODD()
	{
		Value = InlineArrayHelper.Create<InlineArray4_Double, double>(new double[4] { 0.4808983469629878, 0.28853900817779266, 0.2060992915555662, 0.1602994489876626 });
	}
}
