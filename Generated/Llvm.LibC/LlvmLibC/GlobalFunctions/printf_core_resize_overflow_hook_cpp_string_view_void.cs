using AssetRipper.Translation.LlvmIR.Runtime;
using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZN19__llvm_libc_20_1_2_11printf_core20resize_overflow_hookENS_3cpp11string_viewEPv")]
[DemangledName("__llvm_libc_20_1_2_::printf_core::resize_overflow_hook(__llvm_libc_20_1_2_::cpp::string_view, void*)")]
internal static partial class printf_core_resize_overflow_hook_cpp_string_view_void
{
	public unsafe static readonly void* __pointer = PointerIndices.Register((delegate*<void*, long, printf_core_WriteBuffer*, int>)(&Invoke));

	public unsafe static int Invoke([MangledName("new_str.coerce0")] void* new_str, [MangledName("new_str.coerce1")] long target, [MangledName("target")] printf_core_WriteBuffer* wb)
	{
		cpp_string_view cpp_string_view2 = default(cpp_string_view);
		void* ptr = null;
		long num = 0L;
		sbyte b = 0;
		void* ptr2 = null;
		unchecked
		{
			*(void**)(&cpp_string_view2) = new_str;
			((long*)(&cpp_string_view2))[1] = target;
			llvm_lifetime_start_p0.Invoke(8L, &ptr);
			ptr = wb;
			llvm_lifetime_start_p0.Invoke(8L, &num);
			num = cpp_string_view_size_const.Invoke(&cpp_string_view2) + ((printf_core_WriteBuffer*)ptr)->buff_cur;
			llvm_lifetime_start_p0.Invoke(1L, &b);
			b = ((((printf_core_WriteBuffer*)ptr)->buff == ((printf_core_WriteBuffer*)ptr)->init_buff) ? ((sbyte)1) : ((sbyte)0));
			llvm_lifetime_start_p0.Invoke(8L, &ptr2);
			ptr2 = (((b & 1) != 1) ? realloc.Invoke(((printf_core_WriteBuffer*)ptr)->buff, num + 1L) : malloc.Invoke(num + 1L));
			int result;
			if (ptr2 == null)
			{
				if (((printf_core_WriteBuffer*)ptr)->buff != ((printf_core_WriteBuffer*)ptr)->init_buff)
				{
					free.Invoke(((printf_core_WriteBuffer*)ptr)->buff);
				}
				result = -6;
			}
			else
			{
				if ((b & 1) == 1)
				{
					inline_memcpy_void_void_const_unsigned_long.Invoke(ptr2, ((printf_core_WriteBuffer*)ptr)->buff, ((printf_core_WriteBuffer*)ptr)->buff_cur);
				}
				((printf_core_WriteBuffer*)ptr)->buff = ptr2;
				inline_memcpy_void_void_const_unsigned_long.Invoke((byte*)((printf_core_WriteBuffer*)ptr)->buff + ((printf_core_WriteBuffer*)ptr)->buff_cur, cpp_string_view_data_const.Invoke(&cpp_string_view2), cpp_string_view_size_const.Invoke(&cpp_string_view2));
				((printf_core_WriteBuffer*)ptr)->buff_cur = num;
				((printf_core_WriteBuffer*)ptr)->buff_len = num;
				result = 0;
			}
			llvm_lifetime_end_p0.Invoke(8L, &ptr2);
			llvm_lifetime_end_p0.Invoke(1L, &b);
			llvm_lifetime_end_p0.Invoke(8L, &num);
			llvm_lifetime_end_p0.Invoke(8L, &ptr);
			return result;
		}
	}
}
