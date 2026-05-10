using System;
using System.Runtime.CompilerServices;
using LlvmLibC.Helpers;
using LlvmLibC.InlineArrays;

namespace LlvmLibC.GlobalVariables;

[MangledName("_ZN19__llvm_libc_20_1_2_3fmaL17THIRTYTWO_OVER_PIE")]
[DemangledName("__llvm_libc_20_1_2_::fma::THIRTYTWO_OVER_PI")]
internal static partial class fma_THIRTYTWO_OVER_PI
{
	[FixedAddressValueType]
	private static InlineArray5_Double __value;

	public unsafe static InlineArray5_Double* Pointer => unchecked((InlineArray5_Double*)Unsafe.AsPointer(ref __value));

	public static InlineArray5_Double Value
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

	unsafe static fma_THIRTYTWO_OVER_PI()
	{
		Value = InlineArrayHelper.Create<InlineArray5_Double, double>(new double[5]
		{
			32.0 / Math.PI,
			-6.297176536058395E-16,
			-3.4308596105257613E-32,
			2.5771404565101158E-48,
			-4.992885090182308E-65
		});
		PointerIndices.Register(Pointer);
	}
}
