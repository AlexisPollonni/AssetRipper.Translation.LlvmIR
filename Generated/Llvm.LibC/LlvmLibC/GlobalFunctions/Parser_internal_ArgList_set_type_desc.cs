using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Parser_internal_ArgList_set_type_desc
{
	[MangledName("_ZN19__llvm_libc_20_1_2_11printf_core6ParserINS_8internal7ArgListEE13set_type_descEmNS0_8TypeDescE")]
	[DemangledName("__llvm_libc_20_1_2_::printf_core::Parser<__llvm_libc_20_1_2_::internal::ArgList>::set_type_desc(unsigned long, __llvm_libc_20_1_2_::printf_core::TypeDesc)")]
	public unsafe static void Invoke([MangledName("this")] Printf_core_Parser* This, [MangledName("index")][NativeType("unsigned long")] long Index, [MangledName("value.coerce")][NativeType("__llvm_libc_20_1_2_::printf_core::TypeDesc")] short Value)
	{
		Printf_core_TypeDesc printf_core_TypeDesc = default(Printf_core_TypeDesc);
		unchecked
		{
			*(short*)(&printf_core_TypeDesc) = Value;
			if (Index != 0L && (ulong)Index <= 128uL)
			{
				Llvm_memcpy_p0_p0_i64.Invoke((byte*)(&This->Desc_arr) + (nint)(Index - 1L) * sizeof(Printf_core_TypeDesc), &printf_core_TypeDesc, 2L, isVolatile: false);
			}
		}
	}
}
