using System.Runtime.CompilerServices;
using AssetRipper.Translation.LlvmIR.Runtime;
using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.InlineArrays;

namespace LlvmLibC.GlobalVariables;

[MangledName("_ZN19__llvm_libc_20_1_2_7genericL20THIRTYTWO_OVER_PI_28E")]
[DemangledName("__llvm_libc_20_1_2_::generic::THIRTYTWO_OVER_PI_28")]
internal static partial class Generic_THIRTYTWO_OVER_PI_28
{
	[FixedAddressValueType]
	private static InlineArray8_Double __value;

	public unsafe static InlineArray8_Double* Pointer => unchecked((InlineArray8_Double*)Unsafe.AsPointer(ref __value));

	public static InlineArray8_Double Value
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

	unsafe static Generic_THIRTYTWO_OVER_PI_28()
	{
		Value = InlineArrayHelper.Create<InlineArray8_Double, double>(new double[8] { 10.185916364192963, -6.3116611659364E-09, 8.660585562923569E-18, -9.29814060431502E-27, 2.1105153474019847E-35, -2.915099943113601E-44, -7.291519633790914E-53, 5.403682506724226E-62 });
		_ = Pointer;
	}
}
