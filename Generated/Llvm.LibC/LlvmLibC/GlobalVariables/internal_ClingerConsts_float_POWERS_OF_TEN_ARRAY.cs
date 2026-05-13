using System.Runtime.CompilerServices;
using AssetRipper.Translation.LlvmIR.Runtime;
using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.InlineArrays;

namespace LlvmLibC.GlobalVariables;

[MangledName("_ZN19__llvm_libc_20_1_2_8internal13ClingerConstsIfE19POWERS_OF_TEN_ARRAYE")]
[DemangledName("__llvm_libc_20_1_2_::internal::ClingerConsts<float>::POWERS_OF_TEN_ARRAY")]
internal static partial class internal_ClingerConsts_float_POWERS_OF_TEN_ARRAY
{
	[FixedAddressValueType]
	private static InlineArray11_Single __value;

	public unsafe static InlineArray11_Single* Pointer => unchecked((InlineArray11_Single*)Unsafe.AsPointer(ref __value));

	public static InlineArray11_Single Value
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

	unsafe static internal_ClingerConsts_float_POWERS_OF_TEN_ARRAY()
	{
		Value = InlineArrayHelper.Create<InlineArray11_Single, float>(new float[11]
		{
			1f, 10f, 100f, 1000f, 10000f, 100000f, 1000000f, 10000000f, 100000000f, 1E+09f,
			1E+10f
		});
		PointerIndices.Register(Pointer);
	}
}
