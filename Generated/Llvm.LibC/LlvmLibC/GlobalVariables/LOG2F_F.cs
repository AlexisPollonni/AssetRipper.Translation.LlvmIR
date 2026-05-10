using System.Runtime.CompilerServices;
using LlvmLibC.Helpers;
using LlvmLibC.InlineArrays;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalVariables;

[MangledName("_ZN19__llvm_libc_20_1_2_L7LOG2F_FE")]
[DemangledName("__llvm_libc_20_1_2_::LOG2F_F")]
internal static partial class LOG2F_F
{
	[FixedAddressValueType]
	private static cpp_array_etzvdw __value;

	public unsafe static cpp_array_etzvdw* Pointer => unchecked((cpp_array_etzvdw*)Unsafe.AsPointer(ref __value));

	public static cpp_array_etzvdw Value
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

	unsafe static LOG2F_F()
	{
		Value = new cpp_array_etzvdw
		{
			Data = InlineArrayHelper.Create<InlineArray32_Single, float>(new float[32]
			{
				0f, 0.04439412f, 0.08746284f, 0.12928301f, 0.169925f, 0.20945336f, 0.24792752f, 0.2854022f, 0.32192808f, 0.357552f,
				0.3923174f, 0.42626476f, 0.45943162f, 0.4918531f, 0.52356195f, 0.55458885f, 0.5849625f, 0.61470985f, 0.64385617f, 0.6724253f,
				0.7004397f, 0.7279205f, 0.7548875f, 0.78135973f, 0.8073549f, 0.83289003f, 0.85798097f, 0.88264304f, 0.9068906f, 0.9307373f,
				0.95419633f, 0.9772799f
			})
		};
		PointerIndices.Register(Pointer);
	}
}
