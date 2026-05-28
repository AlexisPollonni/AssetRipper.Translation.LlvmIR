using System.Runtime.CompilerServices;
using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalVariables;

[MangledName("_ZN19__llvm_libc_20_1_2_10shm_common10SHM_PREFIXE")]
[DemangledName("__llvm_libc_20_1_2_::shm_common::SHM_PREFIX")]
internal static partial class Shm_common_SHM_PREFIX
{
	[FixedAddressValueType]
	private static Cpp_string_view __value;

	public unsafe static Cpp_string_view* Pointer => unchecked((Cpp_string_view*)Unsafe.AsPointer(ref __value));

	public static Cpp_string_view Value
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

	unsafe static Shm_common_SHM_PREFIX()
	{
		Value = new Cpp_string_view
		{
			Span_data = Str_2_113.Pointer,
			Span_size = 9L
		};
		_ = Pointer;
	}
}
