using LlvmLibC.Helpers;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZNK19__llvm_libc_20_1_2_11printf_core8TypeDesceqERKS1_")]
[DemangledName("__llvm_libc_20_1_2_::printf_core::TypeDesc::operator==(__llvm_libc_20_1_2_::printf_core::TypeDesc const&) const")]
internal static partial class printf_core_TypeDesc_operator_printf_core_TypeDesc_const_const
{
	public unsafe static bool Invoke(void* @this, void* other)
	{
		return unchecked((byte)((printf_core_TypeDesc*)@this)->size == (byte)((printf_core_TypeDesc*)other)->size && (byte)((printf_core_TypeDesc*)@this)->primary_type == (byte)((printf_core_TypeDesc*)other)->primary_type);
	}
}
