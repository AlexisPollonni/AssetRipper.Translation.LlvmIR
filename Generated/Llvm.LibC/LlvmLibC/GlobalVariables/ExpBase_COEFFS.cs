using System.Runtime.CompilerServices;
using AssetRipper.Translation.LlvmIR.Runtime;
using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.InlineArrays;

namespace LlvmLibC.GlobalVariables;

[MangledName("_ZN19__llvm_libc_20_1_2_7ExpBase6COEFFSE")]
[DemangledName("__llvm_libc_20_1_2_::ExpBase::COEFFS")]
internal static partial class ExpBase_COEFFS
{
	[FixedAddressValueType]
	private static InlineArray4_Double __value;

	public unsafe static InlineArray4_Double* Pointer => unchecked((InlineArray4_Double*)Unsafe.AsPointer(ref __value));

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

	unsafe static ExpBase_COEFFS()
	{
		Value = InlineArrayHelper.Create<InlineArray4_Double, double>(new double[4] { 0.49999999999402833, 0.1666666666675198, 0.04166687030887442, 0.008333344969662029 });
		_ = Pointer;
	}
}
