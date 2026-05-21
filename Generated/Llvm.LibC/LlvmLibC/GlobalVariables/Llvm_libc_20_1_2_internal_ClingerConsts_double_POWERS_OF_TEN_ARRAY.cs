using System.Runtime.CompilerServices;
using AssetRipper.Translation.LlvmIR.Runtime;
using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.InlineArrays;

namespace LlvmLibC.GlobalVariables;

[MangledName("_ZN19__llvm_libc_20_1_2_8internal13ClingerConstsIdE19POWERS_OF_TEN_ARRAYE")]
[DemangledName("__llvm_libc_20_1_2_::internal::ClingerConsts<double>::POWERS_OF_TEN_ARRAY")]
internal static partial class Llvm_libc_20_1_2_internal_ClingerConsts_double_POWERS_OF_TEN_ARRAY
{
	[FixedAddressValueType]
	private static InlineArray23_Double __value;

	public unsafe static InlineArray23_Double* Pointer => unchecked((InlineArray23_Double*)Unsafe.AsPointer(ref __value));

	public static InlineArray23_Double Value
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

	unsafe static Llvm_libc_20_1_2_internal_ClingerConsts_double_POWERS_OF_TEN_ARRAY()
	{
		Value = InlineArrayHelper.Create<InlineArray23_Double, double>(new double[23]
		{
			1.0, 10.0, 100.0, 1000.0, 10000.0, 100000.0, 1000000.0, 10000000.0, 100000000.0, 1000000000.0,
			10000000000.0, 100000000000.0, 1000000000000.0, 10000000000000.0, 100000000000000.0, 1000000000000000.0, 10000000000000000.0, 1E+17, 1E+18, 1E+19,
			1E+20, 1E+21, 1E+22
		});
		PointerIndices.Register(Pointer);
	}
}
