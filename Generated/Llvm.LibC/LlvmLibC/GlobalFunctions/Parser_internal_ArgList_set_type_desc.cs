using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Parser_internal_ArgList_set_type_desc
{
	[MangledName("_ZN19__llvm_libc_20_1_2_11printf_core6ParserINS_8internal7ArgListEE13set_type_descEmNS0_8TypeDescE")]
	[DemangledName("__llvm_libc_20_1_2_::printf_core::Parser<__llvm_libc_20_1_2_::internal::ArgList>::set_type_desc(unsigned long, __llvm_libc_20_1_2_::printf_core::TypeDesc)")]
	public unsafe static void Invoke(printf_core_Parser* @this, [NativeType("unsigned long")] long index, [MangledName("value.coerce")][NativeType("__llvm_libc_20_1_2_::printf_core::TypeDesc")] short value)
	{
		printf_core_TypeDesc printf_core_TypeDesc2 = default(printf_core_TypeDesc);
		unchecked
		{
			*(short*)(&printf_core_TypeDesc2) = value;
			if (index != 0L && (ulong)index <= 128uL)
			{
				llvm_memcpy_p0_p0_i64.Invoke((byte*)(&@this->desc_arr) + (nint)(index - 1L) * sizeof(printf_core_TypeDesc), &printf_core_TypeDesc2, 2L, isVolatile: false);
			}
		}
	}
}
