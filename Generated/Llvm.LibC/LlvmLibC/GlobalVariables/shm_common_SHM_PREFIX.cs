using System.Runtime.CompilerServices;
using AssetRipper.Translation.LlvmIR.Runtime;
using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalVariables;

[MangledName("_ZN19__llvm_libc_20_1_2_10shm_common10SHM_PREFIXE")]
[DemangledName("__llvm_libc_20_1_2_::shm_common::SHM_PREFIX")]
internal static partial class shm_common_SHM_PREFIX
{
	[FixedAddressValueType]
	private static cpp_string_view __value;

	public unsafe static cpp_string_view* Pointer => unchecked((cpp_string_view*)Unsafe.AsPointer(ref __value));

	public static cpp_string_view Value
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

	unsafe static shm_common_SHM_PREFIX()
	{
		Value = new cpp_string_view
		{
			span_data = str_2_113.Pointer,
			span_size = 9L
		};
		PointerIndices.Register(Pointer);
	}
}
