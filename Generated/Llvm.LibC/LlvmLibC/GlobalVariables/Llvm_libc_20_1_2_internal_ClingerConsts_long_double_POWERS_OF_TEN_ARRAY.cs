using System.Runtime.CompilerServices;
using AssetRipper.Translation.LlvmIR.Runtime;
using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.InlineArrays;

namespace LlvmLibC.GlobalVariables;

[MangledName("_ZN19__llvm_libc_20_1_2_8internal13ClingerConstsIeE19POWERS_OF_TEN_ARRAYE")]
[DemangledName("__llvm_libc_20_1_2_::internal::ClingerConsts<long double>::POWERS_OF_TEN_ARRAY")]
internal static partial class Llvm_libc_20_1_2_internal_ClingerConsts_long_double_POWERS_OF_TEN_ARRAY
{
	[FixedAddressValueType]
	private static InlineArray28_Double __value;

	public unsafe static InlineArray28_Double* Pointer => unchecked((InlineArray28_Double*)Unsafe.AsPointer(ref __value));

	public static InlineArray28_Double Value
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

	unsafe static Llvm_libc_20_1_2_internal_ClingerConsts_long_double_POWERS_OF_TEN_ARRAY()
	{
		Value = new InlineArrayBuilder<InlineArray28_Double, double>
		{
			1.0, 10.0, 100.0, 1000.0, 10000.0, 100000.0, 1000000.0, 10000000.0, 100000000.0, 1000000000.0,
			10000000000.0, 100000000000.0, 1000000000000.0, 10000000000000.0, 100000000000000.0, 1000000000000000.0, 10000000000000000.0, 1E+17, 1E+18, 1E+19,
			1E+20, 1E+21, 1E+22, 1E+23, 1E+24, 1E+25, 1E+26, 1E+27
		};
		PointerIndices.Register(Pointer);
	}
}
