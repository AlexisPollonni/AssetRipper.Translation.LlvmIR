using System.Runtime.CompilerServices;
using LlvmLibC.Helpers;
using LlvmLibC.InlineArrays;

namespace LlvmLibC.GlobalVariables;

[MangledName("_ZN19__llvm_libc_20_1_2_9Exp10Base6COEFFSE")]
[DemangledName("__llvm_libc_20_1_2_::Exp10Base::COEFFS")]
internal static partial class Exp10Base_COEFFS
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

	unsafe static Exp10Base_COEFFS()
	{
		Value = InlineArrayHelper.Create<InlineArray5_Double, double>(new double[5] { 2.3025850929940455, 2.650949055207538, 2.0346785923449358, 1.1712608733175955, 0.539382198196542 });
		PointerIndices.Register(Pointer);
	}
}
