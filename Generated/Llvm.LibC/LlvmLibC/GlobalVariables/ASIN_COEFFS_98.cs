using System.Runtime.CompilerServices;
using AssetRipper.Translation.LlvmIR.Runtime;
using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.InlineArrays;

namespace LlvmLibC.GlobalVariables;

[MangledName("_ZN19__llvm_libc_20_1_2_L11ASIN_COEFFSE.98")]
[DemangledName("__llvm_libc_20_1_2_::ASIN_COEFFS (.98)")]
internal static partial class ASIN_COEFFS_98
{
	[FixedAddressValueType]
	private static InlineArray10_Double __value;

	public unsafe static InlineArray10_Double* Pointer => unchecked((InlineArray10_Double*)Unsafe.AsPointer(ref __value));

	public static InlineArray10_Double Value
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

	unsafe static ASIN_COEFFS_98()
	{
		Value = InlineArrayHelper.Create<InlineArray10_Double, double>(new double[10] { 0.1666666666643524, 0.07500000043631075, 0.04464282855956581, 0.03038287087939922, 0.022354969403285588, 0.01754867747630359, 0.01255428255449743, 0.017921006498974375, -0.007317807445779548, 0.03151756303559977 });
		_ = Pointer;
	}
}
