using LlvmLibC.Helpers;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZN19__llvm_libc_20_1_2_11printf_core15file_write_hookENS_3cpp11string_viewEPv")]
[DemangledName("__llvm_libc_20_1_2_::printf_core::file_write_hook(__llvm_libc_20_1_2_::cpp::string_view, void*)")]
internal static partial class printf_core_file_write_hook_cpp_string_view_void
{
	public unsafe static readonly void* __pointer = PointerIndices.Register((delegate*<void*, long, void*, int>)(&Invoke));

	public unsafe static int Invoke([MangledName("new_str.coerce0")] void* new_str, [MangledName("new_str.coerce1")] long fp, [MangledName("fp")] void* target_file)
	{
		cpp_string_view cpp_string_view2 = default(cpp_string_view);
		void* f = null;
		long num = 0L;
		unchecked
		{
			*(void**)(&cpp_string_view2) = new_str;
			((long*)(&cpp_string_view2))[1] = fp;
			llvm_lifetime_start_p0.Invoke(8L, &f);
			f = target_file;
			llvm_lifetime_start_p0.Invoke(8L, &num);
			num = internal_fwrite_unlocked_void_const_unsigned_long_unsigned_long_IO_FILE.Invoke(cpp_string_view_data_const.Invoke(&cpp_string_view2), 1L, cpp_string_view_size_const.Invoke(&cpp_string_view2), f);
			int result = ((num != cpp_string_view_size_const.Invoke(&cpp_string_view2) || internal_ferror_unlocked_IO_FILE.Invoke(f) != 0) ? (-1) : 0);
			llvm_lifetime_end_p0.Invoke(8L, &num);
			llvm_lifetime_end_p0.Invoke(8L, &f);
			return result;
		}
	}
}
