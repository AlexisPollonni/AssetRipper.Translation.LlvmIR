using System.Runtime.CompilerServices;
using AssetRipper.Translation.LlvmIR.Runtime;
using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.InlineArrays;

namespace LlvmLibC.GlobalVariables;

[MangledName("_ZN19__llvm_libc_20_1_2_7genericL28THIRTYTWO_OVER_PI_28_LSB_EXPE")]
[DemangledName("__llvm_libc_20_1_2_::generic::THIRTYTWO_OVER_PI_28_LSB_EXP")]
internal static partial class Generic_THIRTYTWO_OVER_PI_28_LSB_EXP
{
	[FixedAddressValueType]
	private static InlineArray8_Int32 __value;

	public unsafe static InlineArray8_Int32* Pointer => unchecked((InlineArray8_Int32*)Unsafe.AsPointer(ref __value));

	public static InlineArray8_Int32 Value
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

	unsafe static Generic_THIRTYTWO_OVER_PI_28_LSB_EXP()
	{
		Value = InlineArrayHelper.Create<InlineArray8_Int32, int>(new int[8] { -24, -55, -81, -114, -143, -170, -200, -230 });
		_ = Pointer;
	}
}
