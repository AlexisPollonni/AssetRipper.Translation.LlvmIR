using System.Runtime.CompilerServices;
using AssetRipper.Translation.LlvmIR.Runtime;
using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.InlineArrays;

namespace LlvmLibC.GlobalVariables;

[MangledName("_ZN19__llvm_libc_20_1_2_L10LOG_COEFFSE.32")]
[DemangledName("__llvm_libc_20_1_2_::LOG_COEFFS (.32)")]
internal static partial class LOG_COEFFS_32
{
	[FixedAddressValueType]
	private static InlineArray6_Double __value;

	public unsafe static InlineArray6_Double* Pointer => unchecked((InlineArray6_Double*)Unsafe.AsPointer(ref __value));

	public static InlineArray6_Double Value
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

	unsafe static LOG_COEFFS_32()
	{
		Value = InlineArrayHelper.Create<InlineArray6_Double, double>(new double[6] { -0.49999999999999994, 0.3333333333331809, -0.2500000000337281, 0.20000003128645172, -0.16666611106179713, 0.14141878713807074 });
		PointerIndices.Register(Pointer);
	}
}
