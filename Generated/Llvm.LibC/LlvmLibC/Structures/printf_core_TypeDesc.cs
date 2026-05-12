using System.Runtime.InteropServices;
using LlvmLibC.Enumerations;
using LlvmLibC.Helpers;

namespace LlvmLibC.Structures;

[StructLayout(LayoutKind.Explicit, Size = 2)]
[MangledName("struct.__llvm_libc_20_1_2_::printf_core::TypeDesc")]
[DemangledName("__llvm_libc_20_1_2_::printf_core::TypeDesc")]
public partial struct printf_core_TypeDesc
{
	[FieldOffset(0)]
	public sbyte size;

	[FieldOffset(1)]
	public PrimaryType primary_type;
}
